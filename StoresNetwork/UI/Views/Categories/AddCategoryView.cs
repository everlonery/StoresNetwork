using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Categories
{
    internal class AddCategoryView : View
    {
        Category category;
        public AddCategoryView(string title, Category category) : base(title)
        {
            this.category = category;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть назву: ");
            category.Name = Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
