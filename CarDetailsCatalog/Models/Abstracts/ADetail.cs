using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog.Models.Abstracts
{
    public abstract class ADetail
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int ProducerId { get; set; }
        public string SuitableCarIds { get; set; }
        public double Price { get; set; }


        public Dictionary<string, string> GetCharacteristics()
        {
            return new Dictionary<string, string>
            {
                { "Назва", Name },
                { "Виробник", GetProducerTitleFor((Producer)ProducerId) },
                { "Ціна", Price.ToString() },
            };
        }

        public static int[] GetSuitableCarIdsArrayByString(string ids)
        {
            return Array.ConvertAll(ids.Split('|'), int.Parse);
        }

        public static string GetSuitableCarIdsStringByArray(int[] ids)
        {
            return string.Join("|", ids);
        }

        public static string GetProducerTitleFor(Producer id)
        {
            var titles = new Dictionary<Producer, string>()
            {
                { Producer.Audi, "Audi" },
                { Producer.Bmw, "BMW" },
                { Producer.ToyoTires, "Toyo Tires" },
                { Producer.Volkswagen, "Volkswagen" },
            };
            return titles[id];
        }

        public static Image GetImageForDetailType(DetailType detailType, int width = 95, int height = 95)
        {
            var imagePath =
                "C:\\QWERTY\\Projects\\C#\\AP\\CarDetailsCatalog\\CarDetailsCatalog\\Resources\\Images\\DetailTypes";
            switch (detailType)
            {
                case DetailType.Brakes:
                    imagePath += "\\brakes.png";
                    break;
                case DetailType.Engine:
                    imagePath += "\\engine.png";
                    break;
                case DetailType.Gearbox:
                    imagePath += "\\gearbox.png";
                    break;
                case DetailType.Tires:
                    imagePath += "\\tires.png";
                    break;
                default:
                    imagePath += "\\default.png";
                    break;
            }

            return new Bitmap(Image.FromFile(imagePath), width, height);
        }
    }
}