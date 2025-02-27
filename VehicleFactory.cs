using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    interface IVehicle  // Define the interface properly
    {
        void Drive();  // Ensure Drive() method is declared
    }

    internal class Car1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    internal class Bike1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is driving...");
        }
    }

    class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            if (type.ToLower() == "car")
                return new Car1();
            else if (type.ToLower() == "bike")
                return new Bike1();
            else
                throw new ArgumentException("Invalid vehicle type!");
        }
    }
}
