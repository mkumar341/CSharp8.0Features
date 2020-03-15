using SampleData;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhatNewCSharp8
{
    public static class Common
    {
        // Positional Pattern

        public static bool IsFreeShippingEligible(Customer customer)
        {
            return customer is Customer(_,_ ,_ , _ , true, (_,_,"Finland") ); //  If custoemr has already a purchase and from Finland then Free shipping applies.
        }

        public static bool IsDiscountEligible(Customer customer)
        {
            return customer is { PurchaseHistory: true, CustomerAddress: { Country: "Finland" }  }; // If customer has already  a purchase & from Finland then  discount applies
        }

        public static string LiveBusinessFeed(object business)
        {
            return  business switch
            {
                Customer c => $"New Lead: {c.FullName} with email {c.Email}",
                Order o => o  switch
                {
                    _ when o.Amount > 5000 => $"Big sale of {o.Amount} -  some drinks & snackes in kitchen :)",
                    _ => $"New sale : {o.Amount} by {o.Customer.Email}"
                },

                _ => "Our team is trying :) " // unknown or Default
            };
            
        }
        public static int GetOrderDiscount(Order order)
        {
            return (order.PaymentMethod,order.Customer.CustomerAddress.Country) switch
            {
                (PaymentMethods.CreditCard,"Finland" ) => 5,
                (PaymentMethods.WireTransfer, "US") => 2,
                (_,_) when order.Amount > 5000 => 10,
                _ => 0 // unknown or Default
            };

        }

    }
}
