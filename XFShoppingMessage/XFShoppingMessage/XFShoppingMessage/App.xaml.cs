using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShoppingMessage.Model;
using XFShoppingMessage.Views;

namespace XFShoppingMessage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VitrineView());

            MessagingCenter.Subscribe<string>(this, "telaProdutoDetalhe", (s) =>
            {
                Current.MainPage.Navigation.PushAsync(new ProdutoDetalheView());
            });
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
