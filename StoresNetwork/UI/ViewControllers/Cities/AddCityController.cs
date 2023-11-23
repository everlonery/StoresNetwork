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
        public override ViewController? ShowView()
        {
            options = new List<string>();
            selectedOption = new();
            view = new AddCityView("Додати місто");
            result = view.Show();
            return new InsertSelectCityController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
