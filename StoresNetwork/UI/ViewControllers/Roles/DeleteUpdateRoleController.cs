using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Roles
{
    internal class DeleteUpdateRoleController : DeleteUpdateController
    {
        public DeleteUpdateRoleController(int rowId) : base(rowId)
        {
            parent = new RolesController();
        }
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new DeleteRoleController(rowId);
                    case 1:
                        return new UpdateRoleController(rowId);
                }
            }
            return null;
        }
    }
}
