﻿using System.Collections.Generic;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models.Abstracts;

namespace CarDetailsCatalog.Models.Details
{
    public class Gearbox : ADetail
    {
        public int Gears { get; set; }
        public GearboxType Type { get; set; }

        public override Dictionary<string, string> GetCharacteristics()
        {
            var dict = base.GetCharacteristics();
            dict["Gears"] = Gears.ToString();
            dict["Type"] = GetGearboxTypeTitleFor(Type);
            return dict;
        }

        public static string GetGearboxTypeTitleFor(GearboxType id)
        {
            var titles = new Dictionary<GearboxType, string>()
            {
                { GearboxType.Manual, "Manual" },
                { GearboxType.Automatic, "Automatic" },
            };
            return titles[id];
        }
    }
}