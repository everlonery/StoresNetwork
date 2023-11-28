using StoresNetwork.Database.DataControllers;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Products
{
    internal class DeleteProductController : ViewController
    {
        public int productId;
        public DeleteProductController(int productId)
        {
            this.productId = productId;
        }

        public override ViewController? ShowView()
        {
            selectedOption = new();
            ProductsDataController dataController = new();
            dataController.DeleteProduct(productId);
            return new ProductsController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
