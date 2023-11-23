using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers
{
    internal class DeleteUpdateController : ViewController
    {
        protected ViewController parent;
        public DeleteUpdateController()
        {
            parent = new MainController();
        }
        public override ViewController? ShowView()
        {
            options = new List<string>() { "Видалити", "Змінити" };
            selectedOption = new();
            view = new("DELETE/UPDATE", options, selectedOption);
            result = view.Show();
            return HandleViewResult(parent);
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
