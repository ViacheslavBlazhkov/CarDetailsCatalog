using CarDetailsCatalog.Models.Abstracts;

namespace CarDetailsCatalog.Models.Details
{
    public class Engine : ADetail
    {
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public double FuelConsumption { get; set; }
    }
}