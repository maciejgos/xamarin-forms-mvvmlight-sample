using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_BankOfSanEscobar.Models;
using Xamarin.Forms;

namespace Client_BankOfSanEscobar.Views
{
    public partial class DetailsPage : ContentPage
    {
        private Account selectedAccount;

        public DetailsPage()
        {
        }

        public DetailsPage(Account selectedItem)
        {
            InitializeComponent();

            this.selectedAccount = selectedItem;
        }
    }
}
