using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    interface IDiscountStrategy
    {
        double ApplyDiscount(double total);
    }

    // No Discount Strategy
    class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double total) => total;
    }

    // Percentage Discount Strategy
    class PercentageDiscount : IDiscountStrategy
    {
        private double percentage;
        public PercentageDiscount(double percentage) { this.percentage = percentage; }

        public double ApplyDiscount(double total) => total - (total * percentage / 100);
    }

    // Fixed Amount Discount Strategy
    class FixedAmountDiscount : IDiscountStrategy
    {
        private double amount;
        public FixedAmountDiscount(double amount) { this.amount = amount; }

        public double ApplyDiscount(double total) => total > amount ? total - amount : 0;
    }

    // Shopping Cart
    class ShoppingCart
    {
        private IDiscountStrategy discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy strategy)
        {
            discountStrategy = strategy;
        }

        public double CalculateTotal(double total)
        {
            return discountStrategy.ApplyDiscount(total);
        }
    }
}
