using Formula1.Data;
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
    public partial class DriversView : ContentPage
    {

        public DriversView(DriversViewModel driversViewModel)
        {
            InitializeComponent();

            BindingContext = driversViewModel;
        }


        //private DriverRepository driverRepository;

        //public DriversView()
        //{
        //    InitializeComponent();

        //    driverRepository = new DriverRepository();
        //    DriversList.ItemsSource = driverRepository.FindAll();
        //}

        //private void DriversListItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    Driver driverSelected = e.Item as Driver;

        //    //DisplayAlert("Teste", driverSelected.Name, "OK");

        //    Navigation.PushAsync(new DriverDetailsView(driverSelected));
        //}
    }
}