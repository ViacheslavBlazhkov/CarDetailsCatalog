using System;
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
        public string SuitableCarIds { get; set; }
        public double Price { get; set; }

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
    }
}