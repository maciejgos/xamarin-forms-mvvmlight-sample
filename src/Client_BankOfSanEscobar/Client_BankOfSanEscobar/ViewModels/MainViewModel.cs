using Client_BankOfSanEscobar.Interfaces;
using Client_BankOfSanEscobar.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Client_BankOfSanEscobar.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IAccountService accountService;

        public string Title { get; set; }
        public ObservableCollection<Account> Accounts { get; set; }
        public float AvailableBalance { get; set; }
        
        public MainViewModel(IAccountService accountService)
        {
            if (accountService == null)
                throw new ArgumentNullException("accontService");

            this.accountService = accountService;

            Task.Run(() => Init());
        }

        public async Task Init()
        {
            if (Accounts != null)
                return;

            Accounts = new ObservableCollection<Account>(await accountService.GetAll());
            foreach (var balance in Accounts.Select(a => a.Balance))
                AvailableBalance += balance;
        }
    }
}
