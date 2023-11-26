using StoresNetwork.UI.ViewControllers.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Roles
{
    internal class InsertSelectRoleController : InsertSelectController
    {
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new AddRoleController();
                    case 1:
                        return new RolesController();
                }
            }
            return null;
        }
    }
}
