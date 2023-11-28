using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Products.Fields.Name
{
    internal class ProductNameView : View
    {
        Product product;
        public ProductNameView(string title, Product product) : base(title)
        {
            this.product = product;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть нову назву: ");
            product.Name = Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
