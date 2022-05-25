using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShoppingMessage.Model;

namespace XFShoppingMessage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoDetalheView : ContentPage
    {
        public ProdutoDetalheView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                ProdutoId = 1,
                ProdutoNome = "Teste"
            };

            MessagingCenter.Send<Produto>(produto, "adicionarItem");

            Navigation.PopAsync();
        }
    }
}