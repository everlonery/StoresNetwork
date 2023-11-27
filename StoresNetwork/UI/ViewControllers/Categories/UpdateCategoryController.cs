using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities.Fileds;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoresNetwork.UI.ViewControllers.Categories.Fields.Parent;
using StoresNetwork.UI.ViewControllers.Categories.Fields.Name;

namespace StoresNetwork.UI.ViewControllers.Categories
{
    internal class UpdateCategoryController : ViewController
    {
        public int categoryId;
        public UpdateCategoryController(int categoryId)
        {
            this.categoryId = categoryId;
        }
        public override ViewController? ShowView()
        {
            options = new List<string>();
            selectedOption = new();
            foreach (var category in Category.PropsList())
                options.Add(category.ToString());
            view = new("Поля", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new CategoriesController());
        }

        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new CategoryNameController(categoryId);
                    case 1:
                        return new ParentCategoryController(categoryId);
                }
            }
            return null;
        }
    }
}
