using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
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
    
        public static Image GetImageFor(string title) // TODO: refactor path
        {
            var imagePath = "C:\\QWERTY\\Projects\\C#\\AP\\CarDetailsCatalog\\CarDetailsCatalog\\Resources\\Images";
            switch (title)
            {
                case "Audi":
                    imagePath += "\\Cars\\Brands\\audi.png";
                    break;
                case "Bmw":
                    imagePath += "\\Cars\\Brands\\bmw.png";
                    break;
                case "Porsche":
                    imagePath += "\\Cars\\Brands\\porsche.png";
                    break;
                case "Subaru":
                    imagePath += "\\Cars\\Brands\\subaru.png";
                    break;
            }
            return new Bitmap(Image.FromFile(imagePath), 95, 95);
        }
    }
}