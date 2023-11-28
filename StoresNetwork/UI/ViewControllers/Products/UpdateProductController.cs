using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Categories.Fields.Name;
using StoresNetwork.UI.ViewControllers.Categories.Fields.Parent;
using StoresNetwork.UI.ViewControllers.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoresNetwork.UI.ViewControllers.Products.Fields.Name;
using StoresNetwork.UI.ViewControllers.Products.Fields.Price;


namespace StoresNetwork.UI.ViewControllers.Products
{
    internal class UpdateProductController : ViewController
    {
        public int productId;
        public UpdateProductController(int productId)
        {
            this.productId = productId;
        }
        public override ViewController? ShowView()
        {
            options = new List<string>();
            selectedOption = new();
            foreach (var product in Product.PropsList())
                options.Add(product.ToString());
            view = new("Поля", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new ProductsController());
        }

        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new ProductNameController(productId);
                    case 1:
                        return new ProductPriceController(productId);
                }
            }
            return null;
        }
    }
}
