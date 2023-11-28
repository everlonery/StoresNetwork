using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Products.Fields.Price
{
    internal class ProductPriceView : View
    {
        Product product;
        public ProductPriceView(string title, Product product) : base(title)
        {
            this.product = product;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть нову ціну: ");
            product.Price = Convert.ToDouble(Console.ReadLine());
            return ViewResult.Return;
        }
    }
}
