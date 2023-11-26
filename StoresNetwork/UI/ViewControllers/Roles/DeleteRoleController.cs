using StoresNetwork.Database.DataControllers;
using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Roles
{
    internal class DeleteRoleController : ViewController
    {
        public int roleId;
        public DeleteRoleController(int roleId)
        {
            this.roleId = roleId;
        }

        public override ViewController? ShowView()
        {
            selectedOption = new();
            RolesDataController dataController = new();
            dataController.DeleteRole(roleId);
            return new RolesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
