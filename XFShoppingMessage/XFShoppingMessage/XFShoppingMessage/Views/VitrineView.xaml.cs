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
    public partial class VitrineView : ContentPage
    {
        public int Quantidade { get; set; }

        public VitrineView()
        {
            InitializeComponent();

            Quantidade = 0;

            MessagingCenter.Subscribe<Produto>(this, "adicionarItem", (p) =>
            {
                Quantidade++;
                CarrinhoItens.Text = $"Itens: {Quantidade}";
            });
        }

        private void ProdutoClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProdutoDetalheView());

            MessagingCenter.Send<string>("", "telaProdutoDetalhe");
        }
    }
}