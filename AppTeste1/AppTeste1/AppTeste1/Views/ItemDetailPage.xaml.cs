using AppTeste1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppTeste1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}