using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    sealed class SecuritySystem
    {
        private string password;

        public SecuritySystem(string password)
        {
            this.password = password;
        }

        public void Authenticate()
        {
            Console.Write("Enter Password to Access System: ");
            string input = Console.ReadLine();

            if (input == password)
                Console.WriteLine("Access Granted!");
            else
                Console.WriteLine("Access Denied!");
        }
    }
}
