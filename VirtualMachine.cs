using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Student : Person
    {
        public int RollNo { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"Student Details: Name: {Name}, Age: {Age}, Roll No: {RollNo}");
        }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"Teacher Details: Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
