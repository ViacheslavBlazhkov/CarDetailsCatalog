using System.Linq;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Exceptions;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Factories
{
    public static class DetailFactory
    {
        public static Brakes CreateBrakes(string title, Producer producer, int[] suitableCarIds, double price)
        {
            var newBrakes = new Brakes
            {
                Name = title,
                ProducerId = (int)producer,
                SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(suitableCarIds),
                Price = price
            };
            using (var context = new AppDbContext())
            {
                var brakes = context.Brakes.FirstOrDefault(
                    e =>
                        e.Name == newBrakes.Name &&
                        e.ProducerId == newBrakes.ProducerId
                );
                if (brakes != null)
                {
                    throw new DetailAlreadyExistsException();
                }

                context.Brakes.Add(newBrakes);
                context.SaveChanges();
            }

            return newBrakes;
        }

        public static Engine CreateEngine(string title, Producer producer, int[] suitableCarIds, double price,
            int horsePower,
            int torque, double fuelConsumption)
        {
            var newEngine = new Engine
            {
                Name = title,
                ProducerId = (int)producer,
                SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(suitableCarIds),
                Price = price,
                HorsePower = horsePower,
                Torque = torque,
                FuelConsumption = fuelConsumption
            };
            using (var context = new AppDbContext())
            {
                var engine = context.Engines.FirstOrDefault(
                    e =>
                        e.Name == newEngine.Name &&
                        e.ProducerId == newEngine.ProducerId &&
                        e.HorsePower == newEngine.HorsePower &&
                        e.Torque == newEngine.Torque
                );
                if (engine != null)
                {
                    throw new DetailAlreadyExistsException();
                }

                context.Engines.Add(newEngine);
                context.SaveChanges();
            }

            return newEngine;
        }

        public static Gearbox CreateGearbox(string title, Producer producer, int[] suitableCarIds, double price,
            GearboxType type, int gears)
        {
            var newGearbox = new Gearbox
            {
                Name = title,
                ProducerId = (int)producer,
                SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(suitableCarIds),
                Price = price,
                Type = type,
                Gears = gears
            };
            using (var context = new AppDbContext())
            {
                var gearbox = context.Gearboxes.FirstOrDefault(
                    e =>
                        e.Name == newGearbox.Name &&
                        e.ProducerId == newGearbox.ProducerId &&
                        e.Type == newGearbox.Type &&
                        e.Gears == newGearbox.Gears
                );
                if (gearbox != null)
                {
                    throw new DetailAlreadyExistsException();
                }

                context.Gearboxes.Add(newGearbox);
                context.SaveChanges();
            }

            return newGearbox;
        }

        public static Tire CreateTire(string title, Producer producer, int[] suitableCarIds, double price)
        {
            var newTire = new Tire
            {
                Name = title,
                ProducerId = (int)producer,
                SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(suitableCarIds),
                Price = price,
            };
            using (var context = new AppDbContext())
            {
                var tire = context.Tires.FirstOrDefault(
                    e =>
                        e.Name == newTire.Name &&
                        e.ProducerId == newTire.ProducerId
                );
                if (tire != null)
                {
                    throw new DetailAlreadyExistsException();
                }

                context.Tires.Add(newTire);
                context.SaveChanges();
            }

            return newTire;
        }
    }
}