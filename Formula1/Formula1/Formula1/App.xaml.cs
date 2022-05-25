using Formula1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new DriversView(new ViewModel.DriversViewModel() ))
            {
                BarBackgroundColor = Color.FromHex("#934368"),
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
