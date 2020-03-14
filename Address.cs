using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData
{
    public class Address
    {
        public int PostalCode { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public Address(int postalCode, string street, string country)
        {
            PostalCode = postalCode;
            Street = street;
            Country = country;
        }

        public void Deconstruct(out int postalCode, out string street, out string country)
        {
            postalCode = PostalCode;
            street = Street;
            country = Country;

        }

    }
}
