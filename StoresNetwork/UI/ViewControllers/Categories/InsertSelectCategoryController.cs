using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories
{
    internal class InsertSelectCategoryController : InsertSelectCityController
    {
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new AddCategoryController();
                    case 1:
                        return new CategoriesController();
                }
            }
            return null;
        }
    }
}
