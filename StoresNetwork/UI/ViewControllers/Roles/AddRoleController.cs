using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using StoresNetwork.UI.Views;
using StoresNetwork.UI.Views.Cities;
using StoresNetwork.UI.Views.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Roles
{
    internal class AddRoleController : ViewController
    {
        Role? role;
        public override ViewController? ShowView()
        {
            role = new Role();
            options = new List<string>();
            selectedOption = new();
            view = new AddRoleView("Додати посаду", role);
            result = view.Show();
            RolesDataController dataController = new();
            dataController.InsertRole(role);
            return new InsertSelectRoleController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
