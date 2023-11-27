using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using StoresNetwork.UI.Views.Categories.Fields;
using StoresNetwork.UI.Views.Cities.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories.Fields.Name
{
    internal class CategoryNameController : ViewController
    {
        int categoryId;
        public CategoryNameController(int categoryId)
        {
            this.categoryId = categoryId;
        }

        public override ViewController? ShowView()
        {
            Category category = new();
            view = new CategoryNameView("Зміна назви", category);
            result = view.Show();
            CategoriesDataController dataController = new();
            dataController.UpdateCategoryName(categoryId, category.Name);
            return new CategoriesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
