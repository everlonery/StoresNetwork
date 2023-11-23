using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Cities
{
    internal class AddCityView : View
    {
        public AddCityView(string title) : base(title) { }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nДодати місто: ");
            Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
