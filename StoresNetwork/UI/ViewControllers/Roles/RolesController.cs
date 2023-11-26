using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Roles
{
    internal class RolesController : ViewController
    {
        List<Role> roles;
        public RolesController()
        {
            roles = new List<Role>();
        }
        public override ViewController? ShowView()
        {
            RolesDataController dataController = new();
            roles = dataController.SelectAllRoles().ToList();
            options = new List<string>();
            foreach (var role in roles)
                options.Add(role.ToString());
            selectedOption = new();
            view = new("Посади", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new InsertSelectRoleController());
        }

        protected override ViewController? ControllerAction()
        {
            return new DeleteUpdateRoleController(roles[selectedOption.Index].RoleId);
        }
    }
}
