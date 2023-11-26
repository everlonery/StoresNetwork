using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.Database.Models
{
    internal class City
    {
        public int CityId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Id міста: {CityId} ");
            sb.Append($"Назва: {Name} ");
            return sb.ToString();
        }
        public static List<string> PropsList() => new List<string>() {"Назва міста"};
    }
}
