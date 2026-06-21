using Microsoft.Extensions.Configuration;
using TransformiceAPI.Application.Interfaces;
using TransformiceAPI.Application.Models.Requests;
using TransformiceAPI.Application.Models.Responses;
using TransformiceAPI.Application.Utils;
using TransformiceAPI.Domain.Entities;
using TransformiceAPI.Domain.Interfaces;

namespace TransformiceAPI.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<AuthenticationResponse> Authenticate(AuthenticationRequest request)
        {
            try
            {
                User? user = await _userRepository.GetByAccountName(request.AccountName);

                if (user is null || !EncryptionUtil.VerifyPassword(request.Password, user.Salt, user.Password))
                    throw new HttpRequestException("Usuário ou senha inválidos.", null, System.Net.HttpStatusCode.NotFound);

                await _userRepository.RegisterAccess(user.Id);

                string tokenAccess = TokenUtil.GenerateToken(user.Id, _configuration["JWTSigningKey"] ?? string.Empty);
                AuthenticationResponse response = new AuthenticationResponse(tokenAccess);

                return response;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }
    }
}
