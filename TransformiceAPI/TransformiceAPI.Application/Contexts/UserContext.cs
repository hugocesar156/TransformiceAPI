using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace TransformiceAPI.Application.Contexts
{
    public class UserContext : IUserContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int IdUser => int.Parse(_httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.PrimarySid)?.Value ?? "0");
        public int IdAccount => int.Parse(_httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.PrimarySid)?.Value ?? "0");
    }
}
