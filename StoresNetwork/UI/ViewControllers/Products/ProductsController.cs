using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Products
{
    internal class ProductsController : ViewController
    {
        List<Product> products;
        public ProductsController()
        {
            products = new List<Product>();
        }

        public override ViewController? ShowView()
        {
            ProductsDataController dataController = new();
            products = dataController.SelectAllProducts().ToList();
            options = new List<string>();
            foreach (var product in products)
                options.Add(product.ToString());
            selectedOption = new();
            view = new("Продукти", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new MainController());
        }

        protected override ViewController? ControllerAction()
        {
            return new DeleteUpdateProductController(products[selectedOption.Index].ProductId);
        }
    }
}
