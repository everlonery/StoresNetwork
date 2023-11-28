using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Products
{
    internal class InsertSelectProductController : InsertSelectController
    {
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new AddProductController();
                    case 1:
                        return new ProductsController();
                }
            }
            return null;
        }
    }
}
