using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.ViewControllers.Cities;
using StoresNetwork.UI.Views.Cities.Fields;
using StoresNetwork.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoresNetwork.UI.Views.Roles.Fields;

namespace StoresNetwork.UI.ViewControllers.Roles.Fields
{
    internal class RoleNameController : ViewController
    {
        int roleId;
        public RoleNameController(int roleId)
        {
            this.roleId = roleId;
        }

        public override ViewController? ShowView()
        {
            Role role = new();
            view = new RoleNameView("Зміна назви", role);
            result = view.Show();
            RolesDataController dataController = new();
            dataController.UpdateRoleName(roleId, role.Name);
            return new RolesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
