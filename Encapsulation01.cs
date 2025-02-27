using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class Encapsulation01
    {
        private double balance;

        public Encapsulation01(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, Balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}, Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
}
