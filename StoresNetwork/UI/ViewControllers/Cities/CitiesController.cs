using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class CitiesController : ViewController
    {
        List<City> cities; 
        public CitiesController()
        {
            cities = new List<City>();
        }

        public override ViewController? ShowView()
        {
            CitiesDataController dataController = new();
            cities = dataController.SelectAllCities().ToList();
            options = new List<string>();
            foreach (var city in cities)
                options.Add(city.ToString());
            selectedOption = new();
            view = new("Міста", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new MainController());
        }

        protected override ViewController? ControllerAction()
        {
            return new DeleteUpdateCityController(cities[selectedOption.Index].CityId);
        }
    }
}
