using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoresNetwork.UI.Views;

namespace StoresNetwork.UI.ViewControllers
{
    internal abstract class ViewController
    {
        protected View? view;
        protected List<string>? options;
        protected OptionIndex? selectedOption;
        protected ViewResult? result;
        public abstract ViewController? ShowView();
        protected abstract ViewController? ControllerAction();
        protected ViewController? HandleViewResult(ViewController? parent = null)
        {
            switch (result)
            {
                case ViewResult.Enter:
                    return ControllerAction();
                case ViewResult.Return:
                    if (parent == null)
                    {
                        if (view != null)
                            view.Clear();
                        return null;
                    }
                    return parent;
                default: return null;
            }
        }
    }
}
