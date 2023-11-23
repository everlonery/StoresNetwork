using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork
{
    internal static class Repository
    {
        public static List<string> Cities { get; private set; }
        public static List<string> Stores { get; private set; }
        static Repository()
        {
            Cities = new List<string>();
            Stores = new List<string>();
            FillCities();
            FillStores();
        }

        static void FillCities()
        {
            Cities.AddRange(new List<string>()
            {
                "Луцьк",
                "Рівне",
                "Львів",
                "Одеса",
                "Вінниця"
            });
        }
        static void FillStores()
        {
            Stores.AddRange(new List<string>()
            {
                "АТБ",
                "Сільпо",
                "Сім23",
                "Розетка",
                "Епіцентр"
            });
        }
    }
}
