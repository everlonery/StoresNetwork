using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers
{
    internal class MainController : ViewController
    {
        public override ViewController? ShowView()
        {
            options = new List<string>() { "Міста", "Магазини" };
            selectedOption = new();
            view = new("Головне меню", options, selectedOption);
            result = view.Show();
            return HandleViewResult();
        }
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new InsertSelectCityController();
                    case 1:
                        return new InsertSelectStoreController();
                }
            }
            return null;
        }
    }
}
