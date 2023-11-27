using StoresNetwork.Database.DataControllers;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories
{
    internal class DeleteCategoryController : ViewController
    {
        public int categoryId;
        public DeleteCategoryController(int categoryId)
        {
            this.categoryId = categoryId;
        }

        public override ViewController? ShowView()
        {
            selectedOption = new();
            CategoriesDataController dataController = new();
            dataController.DeleteCategory(categoryId);
            return new CategoriesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
