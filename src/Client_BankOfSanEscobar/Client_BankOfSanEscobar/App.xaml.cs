using Client_BankOfSanEscobar.Services;
using Xamarin.Forms;

namespace Client_BankOfSanEscobar
{
    public partial class App : Application
    {
        private static readonly Locator locator = new Locator();

        public static Locator Locator
        {
            get
            {
                return locator;
            }
        }

        public App()
        {
            InitializeComponent();

            NavigationService navigation = new NavigationService();
            navigation.Configure("MainPage", typeof(Views.MainPage));
            navigation.Configure("DetailsPage", typeof(Views.DetailsPage));

            NavigationPage mainPage = new NavigationPage(new Views.MainPage());
            MainPage = mainPage;

            navigation.Initialize(mainPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
