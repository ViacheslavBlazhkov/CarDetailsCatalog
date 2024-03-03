using System.Collections.Generic;
using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog.Models
{
    public class Detail
    {
        public int Id { get; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int CountryId { get; set; }

        public static string GetDetailTypeTitleFor(DetailType id)
        {
            var titles = new Dictionary<DetailType, string>()
            {
                { DetailType.Brakes, "Brakes" },
                { DetailType.Engine, "Engine" },
                { DetailType.Gearbox, "Gearbox" },
                { DetailType.Tires, "Tires" },
            };
            return titles[id];
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
    }
}