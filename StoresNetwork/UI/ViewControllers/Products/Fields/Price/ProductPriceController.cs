using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.Views.Products.Fields.Name;
using StoresNetwork.UI.Views.Products.Fields.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Products.Fields.Price
{
    internal class ProductPriceController : ViewController
    {
        int productId;
        public ProductPriceController(int productId)
        {
            this.productId = productId;
        }

        public override ViewController? ShowView()
        {
            Product product = new();
            view = new ProductPriceView("Зміна ціни", product);
            result = view.Show();
            ProductsDataController dataController = new();
            dataController.UpdateProductPrice(productId, product.Price);
            return new ProductsController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
