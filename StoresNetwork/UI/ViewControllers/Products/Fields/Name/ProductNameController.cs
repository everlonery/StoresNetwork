using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Categories;
using StoresNetwork.UI.Views.Categories.Fields;
using StoresNetwork.UI.Views.Products.Fields.Name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Products.Fields.Name
{
    internal class ProductNameController : ViewController
    {
        int productId;
        public ProductNameController(int productId)
        {
            this.productId = productId;
        }

        public override ViewController? ShowView()
        {
            Product product = new();
            view = new ProductNameView("Зміна назви", product);
            result = view.Show();
            ProductsDataController dataController = new();
            dataController.UpdateProductName(productId, product.Name);
            return new ProductsController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
