using SampleData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WhatNewCSharp8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Seed some data
            Customer customer = new Customer(new Guid(), "M", "Kumar", "example@studylearnshare.com", true, new Address(1234, "Street 1", "Finland"));
            Product product = new Product(new Guid(), "Phone",1000);
            List<Product> products = new List<Product>();
            products.Add(product);
            Order order = new Order(1001, 1000, PaymentMethods.CreditCard, customer, products);

            Console.WriteLine("Pattern Matching..");

            // Positional Pattern
            Console.WriteLine("Positional Pattern..");
            bool isFreeShippingEligible = Common.IsFreeShippingEligible(customer);
            Console.WriteLine($"Free Shipping: {isFreeShippingEligible} ");

            // Property Pattern
            Console.WriteLine("Property Pattern..");
            bool isDiscountEligible = Common.IsDiscountEligible(customer);
            Console.WriteLine($"Discount: {isDiscountEligible} ");

            // Switch Expressions Pattern
            Console.WriteLine("Switch Expression Pattern..");
            Console.WriteLine(Common.LiveBusinessFeed(customer));
            Console.WriteLine(Common.LiveBusinessFeed(order));

            // Tuple Pattern
            Console.WriteLine("Tuple Expression Pattern..");
            Console.WriteLine($"Discount: {Common.GetOrderDiscount(order)}");

            // Range & Indices

            Console.WriteLine("Sample text");

            // example array list
            var words = new string[]
            {
                "This",
                "is",
                "C# 8",
                "features",
                "demo",
                "example"
            };
            Array.ForEach(words, word => Console.Write($"{word} "));
            Console.WriteLine();

            Console.WriteLine("Last three word:");
            var lastThree = words[^3..];
            Array.ForEach(lastThree, word => Console.Write($"{word} "));
            Console.WriteLine();

            Console.WriteLine("Last word:");

            var last = words[^1];
            Console.Write($"{last} ");
            Console.WriteLine();

            Console.WriteLine("Middle words:");
            var middle = words[2..^1];
            Array.ForEach(middle, word => Console.Write($"{word} "));




        }
    }
}
