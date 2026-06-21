using Microsoft.EntityFrameworkCore;
using TransformiceAPI.Application.Contexts;
using TransformiceAPI.DAL.Context;
using TransformiceAPI.Domain.Entities;
using TransformiceAPI.Domain.Interfaces;

namespace TransformiceAPI.DAL.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DatabaseContext _data;
        private readonly IUserContext _userContext;

        public AccountRepository(DatabaseContext data, IUserContext userContext)
        {
            _data = data;
            _userContext = userContext;
        }

        public async Task<Account> Get()
        {
            Account account = await _data.accounts
                .Include(a => a.id_genderNavigation)
                .Include(a => a.account_levels)
                    .ThenInclude(al => al.id_levelNavigation)
                .Include(a => a.id_titleNavigation)
                .Where(a => a.id == 1)
                .Select(a => new Account(
                    a.id,
                    a.name,
                    new Gender(
                        a.id_genderNavigation.id,
                        a.id_genderNavigation.description),
                    a.inscription_date,
                    new AccountLevel(
                        a.account_levels.First().id,
                        a.account_levels.First().experience,
                        new Level(
                            a.account_levels.First().id_levelNavigation.id,
                            a.account_levels.First().id_levelNavigation.number,
                            a.account_levels.First().id_levelNavigation.experience)),
                    new Title(
                        a.id_titleNavigation.id,
                        a.id_titleNavigation.name),
                    a.normal_mode_saves,
                    a.hard_mode_saves,
                    a.divine_mode_saves,
                    a.cheese_shaman,
                    a.fist_cheese,
                    a.cheese,
                    a.bootcamp,
                    _data.account_titles.Include(at => at.id_titleNavigation).Select(at => new Title(
                        at.id_titleNavigation.id,
                        at.id_titleNavigation.name
                        )).ToList())
                ).FirstAsync();

            return account;
        }
    }
}
