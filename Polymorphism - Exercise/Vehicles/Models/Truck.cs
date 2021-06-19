namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AirCondConsumption = 1.6;
        private const double FuelLoss = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + AirCondConsumption;
        }
        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            this.FuelQuantity = this.FuelQuantity * FuelLoss;
        }

    }
}
