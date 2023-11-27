using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using StoresNetwork.UI.Views.Categories;
using StoresNetwork.UI.Views.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories
{
    internal class AddCategoryController : ViewController
    {
        Category? category;
        public override ViewController? ShowView()
        {
            category = new Category();
            options = new List<string>();
            selectedOption = new();
            view = new AddCategoryView("Додати категорію", category);
            result = view.Show();
            CategoriesDataController dataController = new();
            dataController.InsertCategory(category);
            return new CategoriesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
