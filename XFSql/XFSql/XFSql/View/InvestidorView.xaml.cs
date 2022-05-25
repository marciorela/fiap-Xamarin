using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSql.Config;
using XFSql.Model;
using XFSql.Repository;

namespace XFSql.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvestidorView : ContentPage
    {

        private InvestidorRepository investidorRepository;

        public InvestidorView()
        {
            InitializeComponent();

            investidorRepository = new InvestidorRepository();
            ListViewInvestidor.ItemsSource = investidorRepository.FindAll();


            //IDbPathConfig dbPathConfig = DependencyService.Get<IDbPathConfig>();
            //EntryNome.Text = dbPathConfig.Path;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var investidor = new Investidor();
            investidor.NomeInvestidor = EntryNome.Text;
            investidor.EmailInvestidor = EntryEmail.Text;

            investidorRepository.Insert(investidor);

            ListViewInvestidor.ItemsSource = investidorRepository.FindAll();
        }
    }
}