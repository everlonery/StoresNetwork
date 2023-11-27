using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories
{
    internal class CategoriesController : ViewController
    {
        List<Category> categories;
        public CategoriesController()
        {
            categories = new List<Category>();
        }

        public override ViewController? ShowView()
        {
            CategoriesDataController dataController = new();
            categories = dataController.SelectAllCategories().ToList();
            options = new List<string>();
            foreach (var category in categories)
                options.Add(category.ToString());
            selectedOption = new();
            view = new("Категорії", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new MainController());
        }

        protected override ViewController? ControllerAction()
        {
            return new DeleteUpdateCategoryController(categories[selectedOption.Index].CategoryId);
        }
    }
}
