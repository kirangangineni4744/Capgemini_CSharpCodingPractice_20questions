using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class Manager
    {
        public string Name { get; set; }
    }

    class Department
    {
        public string DeptName { get; set; }
        public Manager Manager { get; set; }

        // Shallow Copy
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        // Deep Copy
        public Department DeepCopy()
        {
            return new Department 
            { 
                DeptName = this.DeptName,
                Manager = new Manager { Name = this.Manager.Name }
            };
        }
    }
}
