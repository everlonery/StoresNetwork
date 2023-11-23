using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Cities
{
    internal class UpdateCityView : View
    {
        public UpdateCityView(string title) : base(title) { }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nЗмінити місто: ");
            Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
