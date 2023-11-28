using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Products
{
    internal class DeleteUpdateProductController : DeleteUpdateController
    {
        public DeleteUpdateProductController(int rowId) : base(rowId)
        {
            parent = new ProductsController();
        }
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new DeleteProductController(rowId);
                    case 1:
                        return new UpdateProductController(rowId);
                }
            }
            return null;
        }
    }
}
