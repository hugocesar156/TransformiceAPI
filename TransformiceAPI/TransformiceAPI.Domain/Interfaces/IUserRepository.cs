using TransformiceAPI.Domain.Entities;

namespace TransformiceAPI.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByAccountName(string accountName);
        Task RegisterAccess(int idUser);
    }
}
