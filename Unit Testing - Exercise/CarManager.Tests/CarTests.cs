//using CarManager1;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            string make = "VW";
            string model = "Golf";
            double fuelConsumption = 5;
            double capacity = 55;
            car = new Car(make, model, fuelConsumption, capacity);
        }

        
        [Test]
        public void ConstructorParametersShouldReturnTheSameResult()
        {
            string expectedMake = "VW";
            string expectedModel = "Golf";
            double expectedFuelConsumption = 5;
            double expectedCapacity = 55;
            double expectedFuelAmount = 0;
            Assert.AreEqual(expectedMake, car.Make);
            Assert.AreEqual(expectedModel, car.Model);
            Assert.AreEqual(expectedFuelConsumption, car.FuelConsumption);
            Assert.AreEqual(expectedCapacity, car.FuelCapacity);
            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
            
        }


        [TestCase(null, "Golf", 5, 55)]
        [TestCase("", "Golf", 5, 55)]
        [TestCase("VW", null, 5, 80)]
        [TestCase("VW", "", 5, 80)]
        [TestCase("VW", "Beetle", 0, 63)]
        [TestCase("Audi", "A7", -5, 55)]
        [TestCase("Audi", "A5", 16, 0)]
        [TestCase("BMW", "318", 10, -50)]
        [TestCase("BMW5", "320", 16.5, 12.3)]

        public void CarDataShoudlBeCorrectAsExpected(string make, string model, double fuelConsumption,
            double fuelCapacitty)
        {
            Assert.That(() => car = new Car(make, model, fuelConsumption, fuelCapacitty), Throws
                .ArgumentException);
        }

        [TestCase(-15)]
        [TestCase(0)]
        [TestCase(-65)]
        public void RefuelShouldNotBeZeroOrNegative(double fuelToRefuel)
        => Assert.That(() => car.Refuel(fuelToRefuel), Throws.ArgumentException);

        [TestCase(20)]
        [TestCase(60)]
        public void RefuelShouldAddFuelToFuelAmount(double fuelToRefuel)
        {
            var fuelAmount = car.FuelAmount + fuelToRefuel;
            if (fuelAmount > car.FuelCapacity) fuelAmount = car.FuelCapacity;
            car.Refuel(fuelToRefuel);
            Assert.AreEqual(car.FuelAmount, fuelAmount);
        }

        [TestCase(50)]
        [TestCase(250)]
        [TestCase(150)]
        public void FuelAmountShoudlBeLessThanFuelNeeded(double distance)
        {
            Assert.Throws<InvalidOperationException>(()
                => car.Drive(distance));
        }

        [TestCase(63)]
        [TestCase(112)]
        [TestCase(236)]

        public void FuelAmountValueShouldBeDecreasedWhenDrive(double distance)
        {
            double fuelToRefuel = 55;
            car.Refuel(fuelToRefuel);
            car.Drive(distance);
            double fuelNeeded = (distance / 100) * car.FuelConsumption;
            
            Assert.AreEqual(car.FuelAmount, (fuelToRefuel - fuelNeeded));
        }


       
    }
}