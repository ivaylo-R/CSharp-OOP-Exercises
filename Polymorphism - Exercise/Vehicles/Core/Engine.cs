using System;

using Vehicles.Factories;
using Vehicles.IO.Contracts;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        private readonly IReadable reader;
        private readonly IWritable writer;

        private VehicleFactory vehicleFactory;

        public Engine(IReadable reader, IWritable writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = new VehicleFactory();
        }

        public void Run()
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
            Vehicle bus = CreateVehicle();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var cmdArgs = this.reader.ReadLine().Split();
                try
                {
                    ProcessCommand(car, truck,bus, cmdArgs);
                }
                catch (InvalidOperationException ioe)
                {
                    this.writer.WriteLine(ioe.Message);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }

        private void ProcessCommand(Vehicle car, Vehicle truck, Vehicle bus, string[] cmd)
        {
            var command = cmd[0];
            var type = cmd[1];
            var quantity = double.Parse(cmd[2]);
            switch (command)
            {
                case "Drive":
                    switch (type)
                    {
                        case "Car":
                            this.writer.WriteLine(car.Drive(quantity));
                            break;
                        case "Truck":
                            this.writer.WriteLine(truck.Drive(quantity));
                            break;
                        case "Bus":
                            this.writer.WriteLine(bus.Drive(quantity));
                            break;
                    }
                    break;
                case "DriveEmpty":
                    this.writer.WriteLine(bus.DriveEmpty(quantity));
                    break;
                case "Refuel":
                    switch (type)
                    {
                        case "Car":
                           car.Refuel(quantity);
                            break;
                        case "Truck":
                            truck.Refuel(quantity);
                            break;
                        case "Bus":
                            bus.Refuel(quantity);
                            break;
                    }
                    break;
                    
            }
        }

        private Vehicle CreateVehicle()
        {
            var vehicleArgs = this.reader.ReadLine().Split();
            string type = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double fuelConsumption = double.Parse(vehicleArgs[2]);
            double tankCapacity = double.Parse(vehicleArgs[3]);
            
            return this.vehicleFactory.CreateVehicle(type, fuelQuantity, fuelConsumption,tankCapacity);
        }
    }
}
