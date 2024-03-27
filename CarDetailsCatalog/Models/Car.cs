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

        public static Image GetImageForBrand(Brand brand, int width = 95, int height = 95)
        {
            var imagePath =
                "C:\\QWERTY\\Projects\\C#\\AP\\CarDetailsCatalog\\CarDetailsCatalog\\Resources\\Images\\Brands";
            switch (brand)
            {
                case Brand.Audi:
                    imagePath += "\\audi.png";
                    break;
                case Brand.Bmw:
                    imagePath += "\\bmw.png";
                    break;
                case Brand.Porsche:
                    imagePath += "\\porsche.png";
                    break;
                case Brand.Subaru:
                    imagePath += "\\subaru.png";
                    break;
                default:
                    imagePath += "\\default.png";
                    break;
            }

            return new Bitmap(Image.FromFile(imagePath), width, height);
        }
    }
}