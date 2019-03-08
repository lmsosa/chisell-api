using ChiSell.Domain.Common;
using ChiSell.Domain.Customers;
using ChiSell.Domain.Products;
using System;
using System.Collections.Generic;

namespace ChiSell.Domain.Orders
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
            Seller = new Seller();
            Customer = new Customer();
            ShippingAddress = new Address();
        }

        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public OrderState State { get; set; }

        public IList<OrderItem> Items { get; set; }

        public Seller Seller { get; set; }

        public Customer Customer { get; set; }

        public Address ShippingAddress { get; set; }

        public decimal Total { get; set; }
    }
}
