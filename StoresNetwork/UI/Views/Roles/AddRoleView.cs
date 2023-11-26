using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Roles
{
    internal class AddRoleView : View
    {
        Role role;
        public AddRoleView(string title, Role role) : base(title)
        {
            this.role = role;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть назву: ");
            role.Name = Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
