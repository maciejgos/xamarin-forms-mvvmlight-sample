using Client_BankOfSanEscobar.Interfaces;
using Client_BankOfSanEscobar.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Client_BankOfSanEscobar.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IAccountService accountService;
        private readonly INavigationService navigationService;

        public string Title { get; set; }
        public ObservableCollection<Account> Accounts { get; set; }
        public float AvailableBalance { get; set; }
        public Account SelectedItem { get; set; }

        public RelayCommand<Account> ShowDetailsCommand { get; set; }

        public MainViewModel(IAccountService accountService, INavigationService navigationService)
        {
            if (accountService == null)
                throw new ArgumentNullException("accontService");

            this.accountService = accountService;
            this.navigationService = navigationService;

            InitializeCommands();

            Task.Run(() => Init());
        }

        private void InitializeCommands()
        {
            ShowDetailsCommand = new RelayCommand<Account>(account => navigationService.NavigateTo("DetailsPage", account));
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
