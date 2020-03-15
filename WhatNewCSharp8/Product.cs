using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Product(Guid id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Product -> Id: {Id} Name: {Name} Price:{Price}";
        }

    }


}
