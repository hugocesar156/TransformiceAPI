using TransformiceAPI.Domain.Entities;

namespace TransformiceAPI.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account> Get();
    }
}
