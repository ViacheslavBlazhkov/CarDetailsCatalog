﻿using System.Collections.Generic;
using System.Globalization;
using CarDetailsCatalog.Models.Abstracts;

namespace CarDetailsCatalog.Models.Details
{
    public class Engine : ADetail
    {
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public double FuelConsumption { get; set; }

        public override Dictionary<string, string> GetCharacteristics()
        {
            var dict = base.GetCharacteristics();
            dict["Horse Power"] = HorsePower.ToString();
            dict["Torque"] = Torque.ToString();
            dict["Fuel Consumption"] = FuelConsumption.ToString(CultureInfo.CurrentCulture);
            return dict;
        }
    }
}