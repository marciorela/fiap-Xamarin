using Formula1.Models;
using Formula1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriverDetailsView : ContentPage
    {


        public DriverDetailsView(DriverDetailsViewModel driverDetailsViewModel)
        {
            InitializeComponent();

            BindingContext = driverDetailsViewModel;

            //ImageDriver.Source = driver.Photo;
            //LabelNameDriver.Text = driver.Name;
        }
    }
}