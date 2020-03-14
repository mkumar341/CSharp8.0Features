using System;

namespace SampleData
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public bool PurchaseHistory { get; set; }

        public string Email { get; set; }
        public Address CustomerAddress { get; set; }

        public Customer(Guid id, string firstname, string lastname, string email, bool purchaseHistory, Address address)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PurchaseHistory = purchaseHistory;
            CustomerAddress = address;
        }

        //Deconstruct
        public void Deconstruct(out Guid id, out string firstname, out string lastname, out string email, out bool purchaseHistory, out Address address)
        {
            id = Id;
            firstname = FirstName;
            lastname = LastName;
            email = Email;
            purchaseHistory = PurchaseHistory;
            address = CustomerAddress;
        }


        public override string ToString()
        {
            return $"Customer -> Id: {Id} First Name: {FirstName} Last Name:{LastName} Email: {Email} Street:{CustomerAddress.Street} Postal:{CustomerAddress.PostalCode} Country:{CustomerAddress.Country}";
        }

    }
}
