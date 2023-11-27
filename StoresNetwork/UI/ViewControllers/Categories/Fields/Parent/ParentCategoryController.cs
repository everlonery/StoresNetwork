using StoresNetwork.UI.ViewControllers.Cities;
using StoresNetwork.UI.ViewControllers.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories.Fields.Parent
{
    internal class ParentCategoryController : ViewController
    {
        public int categoryId;
        public ParentCategoryController(int categoryId)
        {
            this.categoryId = categoryId;
        }
        public override ViewController? ShowView()
        {
            options = new List<string>() { "Видалити", "Змінити" };
            selectedOption = new();
            view = new("Зміна батьківської категорії", options, selectedOption);
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
                        return new DeleteParentCategoryController(categoryId);
                    case 1:
                        return new SetParentCategoryController(categoryId);
                }
            }
            return null;
        }
    }
}
