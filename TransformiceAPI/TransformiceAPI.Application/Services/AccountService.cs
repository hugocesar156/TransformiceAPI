using TransformiceAPI.Application.Interfaces;
using TransformiceAPI.Application.Models.Responses;
using TransformiceAPI.Domain.Entities;
using TransformiceAPI.Domain.Interfaces;

namespace TransformiceAPI.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountResponse> Get()
        {
            try
            {
                Account? account = await _accountRepository.Get();

                if (account is null)
                    throw new HttpRequestException("Falha ao buscar dados da conta.", null, System.Net.HttpStatusCode.NotFound);

                AccountResponse response = new AccountResponse(
                    account.Id,
                    account.Name,
                    account.Gender.Description,
                    account.InscriptionDate,
                    account.AccountLevel.Level.Number,
                    account.AccountLevel.Experience,
                    account.AccountLevel.Level.Experience,
                    account.ActualTitle.Name,
                    account.NormalModeSaves,
                    account.HardModeSaves,
                    account.DivineModeSaves,
                    account.CheeseShaman,
                    account.FirstCheese,
                    account.Cheese,
                    account.Bootcamp,
                    account.Titles.Select(t => new Title(
                        t.Id,
                        t.Name))
                    .ToList());

                return response;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }
    }
}
