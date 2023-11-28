using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using StoresNetwork.UI.Views.Cities;
using StoresNetwork.UI.Views.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Products
{
    internal class AddProductController : ViewController
    {
        Product? product;
        public override ViewController? ShowView()
        {
            product = new Product();
            options = new List<string>();
            selectedOption = new();
            view = new AddProductView("Додати продукт", product);
            result = view.Show();
            ProductsDataController dataController = new();
            dataController.InsertProduct(product);
            return new ProductsController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
