using Client_BankOfSanEscobar.Interfaces;
using Client_BankOfSanEscobar.Mock;
using Client_BankOfSanEscobar.Services;
using Client_BankOfSanEscobar.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace Client_BankOfSanEscobar
{
    public class Locator
    {
        public Locator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //ViewModels
            SimpleIoc.Default.Register<MainViewModel>();

            //Services
            SimpleIoc.Default.Register<IAccountService, AccountServiceMock>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
    }
}
