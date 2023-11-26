using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities.Fileds;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoresNetwork.UI.ViewControllers.Roles.Fields;

namespace StoresNetwork.UI.ViewControllers.Roles
{
    internal class UpdateRoleController : ViewController
    {
        public int roleId;
        public UpdateRoleController(int roleId)
        {
            this.roleId = roleId;
        }
        public override ViewController? ShowView()
        {
            options = new List<string>();
            selectedOption = new();
            foreach (var role in Role.PropsList())
                options.Add(role.ToString());
            view = new("Поля", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new RolesController());
        }

        protected override ViewController? ControllerAction()
        {
            return new RoleNameController(roleId);
        }
    }
}
