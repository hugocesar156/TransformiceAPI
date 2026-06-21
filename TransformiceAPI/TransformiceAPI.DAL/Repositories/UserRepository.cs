using Microsoft.EntityFrameworkCore;
using TransformiceAPI.DAL.Context;
using TransformiceAPI.Domain.Entities;
using TransformiceAPI.Domain.Interfaces;

namespace TransformiceAPI.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _data;

        public UserRepository(DatabaseContext data)
        {
            _data = data;
        }

        public async Task<User?> GetByAccountName(string accountName)
        {
            User? user = await _data.users
                .Include(u => u.accounts)
                .Where(u => u.accounts.Any(a => a.name == accountName))
                .Select(u => new User(
                    u.id,
                    u.email,
                    u.password,
                    u.salt,
                    u.last_access))
                .FirstOrDefaultAsync();

            return user;
        }

        public async Task RegisterAccess(int idUser)
        {
            Models.user user = await _data.users.FirstAsync();

            user.last_access = DateTime.Now;
            await _data.SaveChangesAsync();
        }
    }
}
