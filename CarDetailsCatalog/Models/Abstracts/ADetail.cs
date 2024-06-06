using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog.Models.Abstracts
{
    public abstract class ADetail : IDetail
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int ProducerId { get; set; }
        public string SuitableCarIds { get; set; }
        public double Price { get; set; }


        public virtual Dictionary<string, string> GetCharacteristics()
        {
            return new Dictionary<string, string>
            {
                { "Title", Name },
                { "Producer", GetProducerTitleFor((Producer)ProducerId) },
                { "Price", Price.ToString(CultureInfo.CurrentCulture) },
            };
        }

        public static int[] GetSuitableCarIdsArrayByString(string ids) => Array.ConvertAll(ids.Split('|'), int.Parse);

        public static string GetSuitableCarIdsStringByArray(int[] ids) => string.Join("|", ids);

        public static Dictionary<string, Color>[] GetParamsWithColors(Dictionary<string, string> firstDetailParams,
            Dictionary<string, string> secondDetailParams)
        {
            var firstDetailResult = new Dictionary<string, Color>();
            var secondDetailResult = new Dictionary<string, Color>();
            for (int i = 0; i < firstDetailParams.Count; i++)
            {
                var key = firstDetailParams.ElementAt(i).Key;
                if (GetBestForProperty(key) != null)
                {
                    var firstDetailValue = double.Parse(firstDetailParams.ElementAt(i).Value);
                    var secondDetailValue = double.Parse(secondDetailParams.ElementAt(i).Value);
                    if (firstDetailValue == secondDetailValue)
                    {
                        firstDetailResult.Add(key, Color.Gray);
                        secondDetailResult.Add(key, Color.Gray);
                    }
                    else
                    {
                        var bestValue = GetBestBetween(key, firstDetailValue, secondDetailValue);
                        if (bestValue == secondDetailValue)
                        {
                            firstDetailResult.Add(key, Color.SeaGreen);
                            secondDetailResult.Add(key, Color.IndianRed);
                        }
                        else
                        {
                            firstDetailResult.Add(key, Color.IndianRed);
                            secondDetailResult.Add(key, Color.SeaGreen);
                        }
                    }
                }
            }

            Dictionary<string, Color>[] result = { firstDetailResult, secondDetailResult };
            return result;
        }

        public static double GetBestBetween(string property, double firstDetailValue, double secondDetailValue)
        {
            if (GetBestForProperty(property) == "Max")
            {
                return firstDetailValue > secondDetailValue ? firstDetailValue : secondDetailValue;
            }

            return firstDetailValue < secondDetailValue ? firstDetailValue : secondDetailValue;
        }

        public static string GetBestForProperty(string property)
        {
            var dict = new Dictionary<string, string>
            {
                { "Price", "Min" },
                { "Horse Power", "Max" },
                { "Torque", "Max" },
                { "Fuel Consumption", "Min" },
                { "Gears", "Max" },
            };
            return dict.FirstOrDefault(p => p.Key == property).Value;
        }

        public static string GetProducerTitleFor(Producer id)
        {
            var titles = new Dictionary<Producer, string>()
            {
                { Producer.Audi, "Audi" },
                { Producer.Getrag, "Getrag" },
                { Producer.Bmw, "BMW" },
                { Producer.ToyoTires, "Toyo Tires" },
                { Producer.Volkswagen, "Volkswagen" },
                { Producer.ZfFriedrichshafenAg, "ZF Friedrichshafen AG" },
            };
            return titles[id];
        }

        public static Image GetImageForDetailType(DetailType detailType, int width = 95, int height = 95)
        {
            var imagePath = Path.Combine(Helper.GetRootPath(), "CarDetailsCatalog\\Resources\\Images\\DetailTypes");
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