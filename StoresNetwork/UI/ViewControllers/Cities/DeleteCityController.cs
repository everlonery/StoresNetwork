using StoresNetwork.UI.Views.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class DeleteCityController : ViewController
    {

        public override ViewController? ShowView()
        {
            options = new List<string>();
            selectedOption = new();
            view = new DeleteCityView("Видалити місто");
            result = view.Show();
            return new DeleteUpdateCityController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
