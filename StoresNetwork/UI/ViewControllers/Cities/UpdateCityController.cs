using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities.Fileds;
using StoresNetwork.UI.Views.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class UpdateCityController : ViewController
    {
        public int cityId;
        public UpdateCityController(int cityId)
        {
            this.cityId = cityId;
        }
        public override ViewController? ShowView()
        {
            options = new List<string>();
            selectedOption = new();
            foreach (var city in City.PropsList())
                options.Add(city.ToString());
            view = new("Поля", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new CitiesController());
        }

        protected override ViewController? ControllerAction()
        {
            return new CityNameController(cityId);
        }
    }
}
