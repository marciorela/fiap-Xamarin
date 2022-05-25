using Formula1.Data;
using Formula1.Models;
using Formula1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Formula1.ViewModel
{
    public class DriversViewModel : BaseViewModel
    {

        #region properties
        private ObservableCollection<Driver> drivers;

        public ObservableCollection<Driver> Drivers
        {
            get { return drivers; }
            set { SetProperty(ref drivers, value); }
        }

        private Driver selectedDriver;

        public Driver SelectedDriver
        {
            get { return selectedDriver; }
            set { SetProperty(ref selectedDriver, value); }
        }

        private string nameSearch;

        public string NameSearch
        {
            get { return nameSearch; }
            set
            {
                SetProperty(ref nameSearch, value);

                Drivers = new ObservableCollection<Driver>(
                    driverRepository.FindAll().Where(d => d.Name.Contains(nameSearch)).ToList()
                );

                //if (string.IsNullOrWhiteSpace(nameSearch))
                //{
                //    Drivers = new ObservableCollection<Driver>(
                //        driverRepository.FindAll()
                //    );
                //}
                //else
                //{
                //    Drivers = new ObservableCollection<Driver>(
                //        Drivers.Where(d => d.Name.Contains(nameSearch)).ToList()
                //    );
                //}
            }
        }


        private DriverRepository driverRepository;
        #endregion

        #region comamnds
        public ICommand TesteClickedCommand => new Command<Driver>(async (driver) => await App.Current.MainPage.DisplayAlert("Teste", "Clicked", "Ok"));

        public ICommand DriverSelectedCommand => new Command<Driver>(async (driver) =>
            {
                //await App.Current.MainPage.DisplayAlert("Piloto", driver.Name, "Ok");

                var vm = new DriverDetailsViewModel(driver);
                await App.Current.MainPage.Navigation.PushAsync(new DriverDetailsView(vm));
            }
        );

        #endregion

        public DriversViewModel()
        {
            driverRepository = new DriverRepository();

            Drivers = new ObservableCollection<Driver>(driverRepository.FindAll());
        }

    }
}
