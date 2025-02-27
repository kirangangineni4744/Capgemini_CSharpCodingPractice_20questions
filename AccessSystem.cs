using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public virtual void AccessControl()
        {
            Console.WriteLine($"{Username} has basic user access.");
        }
    }

    class Admin : User
    {
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Admin) has full access to all features.");
        }
    }

    class Customer : User
    {
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Customer) has limited access.");
        }
    }
}
