using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.ViewControllers
{
    internal class InsertSelectController : ViewController
    {
        public override ViewController? ShowView()
        {
            options = new List<string>() { "Додати", "Показати список" };
            selectedOption = new();
            view = new("INSERT/SELECT", options, selectedOption);
            result = view.Show();
            return HandleViewResult(new MainController());
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
