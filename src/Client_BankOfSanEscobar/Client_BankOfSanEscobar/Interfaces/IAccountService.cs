using Client_BankOfSanEscobar.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client_BankOfSanEscobar.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAll();
    }
}