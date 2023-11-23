using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoresNetwork.UI.ViewControllers;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class DeleteUpdateCityController : DeleteUpdateController
    {
        public DeleteUpdateCityController()
        {
            parent = new CitiesController();
        }
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new DeleteCityController();
                    case 1:
                        return new UpdateCityController();
                }
            }
            return null;
        }
    }
}
