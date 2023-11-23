using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class InsertSelectCityController : InsertSelectController
    {
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new AddCityController();
                    case 1:
                        return new CitiesController();
                }
            }
            return null;
        }
    }
}
