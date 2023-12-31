﻿using StoresNetwork.Database.DataControllers;
using StoresNetwork.Database.Models;
using StoresNetwork.UI.Views.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.UI.ViewControllers.Cities
{
    internal class DeleteCityController : ViewController
    {
        public int cityId;
        public DeleteCityController(int cityId)
        {
            this.cityId = cityId;
        }

        public override ViewController? ShowView()
        {    
            selectedOption = new();
            CitiesDataController dataController = new();
            dataController.DeleteCity(cityId);
            return new CitiesController();
        }

        protected override ViewController? ControllerAction()
        {
            throw new NotImplementedException();
        }
    }
}
