using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Categories.Fields
{
    internal class CategoryNameView : View
    {
        Category category;
        public CategoryNameView(string title, Category category) : base(title)
        {
            this.category = category;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть нову назву: ");
            category.Name = Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
