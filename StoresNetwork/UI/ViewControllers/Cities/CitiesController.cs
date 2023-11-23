using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class CitiesController : ViewController
    {
        public override ViewController? ShowView()
        {
            options = new List<string>(Repository.Cities);
            selectedOption = new();
            view = new("Міста", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new InsertSelectCityController());
        }

        protected override ViewController? ControllerAction()
        {
            return new DeleteUpdateCityController();
        }
    }
}
