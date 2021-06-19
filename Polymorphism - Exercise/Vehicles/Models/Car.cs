
using Vehicles.Models;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirCondConsumtion = 0.9;
        public Car(double fuelQuantity, double fuelConsumption,double tankCapacity)
            : base(fuelQuantity, fuelConsumption,tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + AirCondConsumtion;
        }

        
       
    }
}
