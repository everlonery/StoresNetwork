using StoresNetwork.UI.ViewControllers.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Categories
{
    internal class DeleteUpdateCategoryController : DeleteUpdateController
    {
        public DeleteUpdateCategoryController(int rowId) : base(rowId)
        {
            parent = new CategoriesController();
        }
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new DeleteCategoryController(rowId);
                    case 1:
                        return new UpdateCategoryController(rowId);
                }
            }
            return null;
        }
    }
}
