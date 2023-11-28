using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Products
{
    internal class AddProductView : View
    {
        Product product;
        public AddProductView(string title, Product product) : base(title)
        {
            this.product = product;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть назву: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Введіть ціну: ");
            product.Price = Convert.ToDouble(Console.ReadLine());
            return ViewResult.Return;
        }
    }
}
