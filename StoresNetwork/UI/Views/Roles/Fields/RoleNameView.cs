using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Roles.Fields
{
    internal class RoleNameView : View
    {
        Role role;
        public RoleNameView(string title, Role role) : base(title)
        {
            this.role = role;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть нову назву: ");
            role.Name = Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
