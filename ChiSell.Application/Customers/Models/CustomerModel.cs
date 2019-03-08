using System;

namespace ChiSell.Application.Customers.Models
{
    public class CustomerModel
    {
        public CustomerModel()
        {
            FullName = string.Empty;
        }

        public Guid Id { get; set; }

        public string FullName { get; set; }
    }
}
