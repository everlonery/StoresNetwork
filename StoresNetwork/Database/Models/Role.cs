using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.Database.Models
{
    internal class Role
    {
        public int RoleId { get; set; }
        public string? Name { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Id посади: {RoleId} ");
            sb.Append($"Назва: {Name} ");
            return sb.ToString();
        }
        public static List<string> PropsList() => new List<string>() { "Назва посади" };
    }
}
