﻿using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.Views.Cities
{
    internal class AddCityView : View
    {
        City city;
        public AddCityView(string title, City city) : base(title) {
        this.city = city;
        }
        public override ViewResult Show()
        {
            Clear();
            DrawTitle();
            Console.WriteLine("\nВведіть назву: ");
            city.Name = Console.ReadLine();
            return ViewResult.Return;
        }
    }
}
