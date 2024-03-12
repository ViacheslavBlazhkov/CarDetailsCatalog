using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog.Models
{
    public class Car
    {
        [Key] public int Id { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int CountryId { get; set; }

        public static string GetBrandTitleFor(Brand brand)
        {
            var titles = new Dictionary<Brand, string>()
            {
                { Brand.Audi, "Audi" },
                { Brand.Bmw, "BMW" },
                { Brand.Porsche, "Porsche" },
                { Brand.Subaru, "Subaru" },
            };
            return titles[brand];
        }

        public static string GetCountryTitleFor(Country country)
        {
            var titles = new Dictionary<Country, string>()
            {
                { Country.France, "France" },
                { Country.Germany, "Germany" },
                { Country.Japan, "Japan" },
                { Country.Usa, "Usa" },
            };
            return titles[country];
        }
    }
}