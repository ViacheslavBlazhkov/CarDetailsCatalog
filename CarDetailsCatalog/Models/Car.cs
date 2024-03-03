using System.Collections.Generic;
using System.Linq;
using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog.Models
{
    public class Car
    {
        public int Id { get; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int CountryId { get; set; }
        
        public static string GetBrandTitleFor(Brand id)
        {
            var titles = new Dictionary<Brand, string>()
            {
                { Brand.Audi, "Audi" },
                { Brand.Bmw, "BMW" },
                { Brand.Porsche, "Porsche" },
                { Brand.Subaru, "Subaru" },
            };
            return titles[id];
        }
        
        public static string GetCountryTitleFor(Country id)
        {
            var titles = new Dictionary<Country, string>()
            {
                { Country.France, "France" },
                { Country.Germany, "Germany" },
                { Country.Japan, "Japan" },
                { Country.Usa, "Usa" },
            };
            return titles[id];
        }
    }
}