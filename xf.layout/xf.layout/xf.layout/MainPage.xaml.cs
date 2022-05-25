using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xf.layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AbsoluteClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.AbsoluteLayout());
        }
    }
}
