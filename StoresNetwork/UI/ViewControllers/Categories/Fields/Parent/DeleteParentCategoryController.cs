using StoresNetwork.Database.DataControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories.Fields.Parent
{
    internal class DeleteParentCategoryController : ViewController
    {
        public int categoryId;
        public DeleteParentCategoryController(int categoryId)
        {
            this.categoryId = categoryId;
        }
        public override ViewController? ShowView()
        {
            selectedOption = new();
            CategoriesDataController dataController = new();
            dataController.DeleteParent(categoryId);
            return new CategoriesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
