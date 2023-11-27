using StoresNetwork.Database.DataControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.Database.Models
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public int ParentId { get; set; }
        public override string ToString()
        {
            CategoriesDataController dataController = new CategoriesDataController();
            var parent = dataController.SelectCategoryParent(ParentId);
            var sb = new StringBuilder();
            sb.Append($"Id категорії: {CategoryId} ");
            sb.Append($"Назва: {Name} ");
            if( parent != null )
                sb.Append($" - - -  {parent.Name} ");
            return sb.ToString();
        }
        public static List<string> PropsList() => new List<string>() { "Назва категорії", "Батьківська категорія" };
    }
}
