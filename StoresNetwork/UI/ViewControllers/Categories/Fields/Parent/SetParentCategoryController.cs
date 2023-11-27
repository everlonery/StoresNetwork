using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories.Fields.Parent
{
    internal class SetParentCategoryController : ViewController
    {
        int categoryId;
        List<Category> categories;
        public SetParentCategoryController(int categoryId)
        {
            this.categoryId = categoryId;
            categories = new List<Category>();
        }
        public override ViewController? ShowView()
        {
            CategoriesDataController dataController = new();
            categories = dataController.GetOtherCategories(categoryId).ToList();
            options = new List<string>();
            foreach (var category in categories)
            {
                if(category.Name!=null)
                    options.Add(category.Name);
            }
            selectedOption = new();
            view = new("Вибір батьківської категорії", options, selectedOption);
            result = view.Show();
            dataController.UpdateCategoryParent(categoryId, categories[selectedOption.Index].CategoryId);
            return new CategoriesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
