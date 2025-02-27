using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key ignition.");
        }
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a self-start button.");
        }
    }

}
