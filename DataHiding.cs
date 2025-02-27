using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class DataHiding
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                    rollNo = value;
                else
                    Console.WriteLine("Roll Number cannot be negative or zero.");
            }
        }
    }
}
