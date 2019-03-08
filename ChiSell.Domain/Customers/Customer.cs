using ChiSell.Domain.Common;
using System;

namespace ChiSell.Domain.Customers
{
    public class Customer
    {
        public Customer()
        {
            FullName = string.Empty;
            Email = string.Empty;
            ShippingAddress = new Address();
            PhoneNumber = string.Empty;
        }

        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public Address ShippingAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}
