using Client_BankOfSanEscobar.Interfaces;
using Client_BankOfSanEscobar.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client_BankOfSanEscobar.Mock
{
    public class AccountServiceMock : IAccountService
    {
        public Task<IEnumerable<Account>> GetAll()
        {
            const int numberOfAccountsToGenerate = 4;
            return Task.Run(() => GenerateAccounts(numberOfAccountsToGenerate));
        }

        private IEnumerable<Account> GenerateAccounts(int numberOfAccounts)
        {
            var accounts = new List<Account>(numberOfAccounts);
            for (int i = 0; i < numberOfAccounts; i++)
            {
                accounts.Add(new Account(name: $"Account {i}", number: $"26200400001545234{i}", balance: 150.56f + i));
            }
            return accounts;
        }
    }
}
