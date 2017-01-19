using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client_BankOfSanEscobar.Models;

namespace Client_BankOfSanEscobar.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAll();
    }
}