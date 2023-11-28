using StoresNetwork.Database.DataControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.Database.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public bool? IsExcise { get; set; }
        public string? PicturePath { get; set; }
        public int CategoryId { get; set; }
        public override string ToString()
        {
            CategoriesDataController dataController = new CategoriesDataController();
            var category = dataController.SelectCategoryParent(CategoryId);
            var sb = new StringBuilder();
            sb.Append($"Id продукту: {ProductId} ");
            sb.Append($"Назва: {Name} ");
            sb.Append($"Ціна: {Price} ");
            sb.Append($"Акцизний: {IsExcise} ");
            sb.Append($"Шлях до зображення: {PicturePath} ");
            if (category != null)
                sb.Append($"Категорія: {category.Name} ");
            return sb.ToString();
        }
        public static List<string> PropsList() => new List<string>() { "Назва продукту", "Ціна"};
    }
}
