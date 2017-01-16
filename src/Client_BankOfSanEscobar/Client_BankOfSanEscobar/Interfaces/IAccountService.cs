using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client_BankOfSanEscobar.Models;

namespace Client_BankOfSanEscobar.Interfaces
{
    public class IAccountService
    {
        public Task<IEnumerable<Account>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}