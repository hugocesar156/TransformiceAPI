using TransformiceAPI.Application.Models.Requests;
using TransformiceAPI.Application.Models.Responses;

namespace TransformiceAPI.Application.Interfaces
{
    public interface IUserService
    {
        Task<AuthenticationResponse> Authenticate(AuthenticationRequest request);
    }
}
