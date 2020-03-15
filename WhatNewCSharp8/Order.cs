using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData
{
    public class Order
    {
        public int Number { get; set; }

        public decimal Amount { get; set; }

        public PaymentMethods PaymentMethod { get; set; }

        public Customer Customer { get; set; }
        public List<Product> LineItems { get; set; }

        public Order(int number, decimal amount, PaymentMethods method, Customer customer, List<Product> products)
        {
            Number = number;
            Amount = amount;
            PaymentMethod = method;
            Customer = customer;
            LineItems = products;
        }
    }
}
