using StoresNetwork.UI.ViewControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork
{
    internal class AppController
    {
		private ViewController? currentController;
		public ViewController? CurrentController
		{
			set 
			{ 
				currentController = value;
				if(currentController != null )
				{
					CurrentController = currentController.ShowView();
                }
            }
		}
		public AppController()
		{
			CurrentController = new MainController();
		}
    }
}
