using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class Bank
    {
        public string AccountHolder { get; set; }
        public static double InterestRate { get; private set; } = 5.0; // Default interest rate

        public static void SetInterestRate(double rate)
        {
            InterestRate = rate;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{AccountHolder} - Interest Rate: {InterestRate}%");
        }
    }
}
