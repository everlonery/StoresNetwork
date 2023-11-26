using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.Views;
using StoresNetwork.UI.Views.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class AddCityController : ViewController
    {
        City? city;
        public override ViewController? ShowView()
        {   
            city = new City();
            options = new List<string>();
            selectedOption = new();
            view = new AddCityView("Додати місто", city);
            result = view.Show();
            CitiesDataController dataController = new();
            dataController.InsertCity(city);
            return new InsertSelectCityController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
