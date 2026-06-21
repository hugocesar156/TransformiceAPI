using TransformiceAPI.Application.Models.Responses;

namespace TransformiceAPI.Application.Interfaces
{
    public interface IAccountService
    {
        Task<AccountResponse> Get();
    }
}
