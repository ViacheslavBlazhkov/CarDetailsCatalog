using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog.Models.Abstracts
{
    public abstract class ADetail
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int ProducerId { get; set; }
        public int[] SuitableCarIds { get; set; }
        public double Price { get; set; }

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

        public void SetSuitableCarIds(int[] ids) // TODO: make it
        {
            //     (using context = new AppDbContext())
            //     SuitableCarIds = string.Join("|", ids);
        }
    }
}