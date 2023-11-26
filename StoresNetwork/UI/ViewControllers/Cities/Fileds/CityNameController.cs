using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.Views.Cities.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities.Fileds
{
    internal class CityNameController : ViewController
    {
        int cityId;
        public CityNameController(int cityId)
        {
            this.cityId = cityId;
        }

        public override ViewController? ShowView()
        {
            City city = new ();
            view = new CityNameView("Зміна назви", city);
            result = view.Show();
            CitiesDataController dataController = new();
            dataController.UpdateCityName(cityId, city.Name);
            return new CitiesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
