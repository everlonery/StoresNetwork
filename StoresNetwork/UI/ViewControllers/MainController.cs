﻿using StoresNetwork.UI.ViewControllers.Categories;
using StoresNetwork.UI.ViewControllers.Cities;
using StoresNetwork.UI.ViewControllers.Products;
using StoresNetwork.UI.ViewControllers.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers
{
    internal class MainController : ViewController
    {
        public override ViewController? ShowView()
        {
            options = new List<string>() { "Міста", "Посади", "Категорії", "Продукти"};
            selectedOption = new();
            view = new("Головне меню", options, selectedOption);
            result = view.Show();
            return HandleViewResult();
        }
        protected override ViewController? ControllerAction()
        {
            if (selectedOption != null)
            {
                switch (selectedOption.Index)
                {
                    case 0:
                        return new InsertSelectCityController();
                    case 1:
                        return new InsertSelectRoleController();
                    case 2:
                        return new InsertSelectCategoryController();
                    case 3:
                        return new InsertSelectProductController();
                }
            }
            return null;
        }
    }
}
