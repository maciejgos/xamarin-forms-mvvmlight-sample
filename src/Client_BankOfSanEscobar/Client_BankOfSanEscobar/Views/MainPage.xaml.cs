using Client_BankOfSanEscobar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Client_BankOfSanEscobar.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Main;
        }

        private void AccountsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //TODO: Add navigation to details page
            Navigation.PushAsync(new DetailsPage((Account)e.SelectedItem));
        }
    }
}
