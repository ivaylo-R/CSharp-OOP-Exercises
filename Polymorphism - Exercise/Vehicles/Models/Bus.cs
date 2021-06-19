using System;
using Vehicles.Common;
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double AirCondConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption { get; protected set; }

        public override string Drive(double distance)
        {
            double fuelNeeded = distance * (this.FuelConsumption+AirCondConsumption);
            if (this.FuelQuantity < fuelNeeded)
            {
                string excMsg = string.Format(ExceptionMessages.NotEnoughFuelExceptionMessage, this.GetType().Name);
                throw new InvalidOperationException(excMsg);
            }
            base.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public override string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }


    }
}
