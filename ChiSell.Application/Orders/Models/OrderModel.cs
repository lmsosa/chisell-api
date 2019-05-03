using ChiSell.Application.Common.Models;
using ChiSell.Application.Customers.Models;
using ChiSell.Application.Products.Models;
using ChiSell.Domain.Orders;
using System;
using System.Collections.Generic;

namespace ChiSell.Application.Orders.Models
{
    public class OrderModel
    {
        public OrderModel()
        {
            Customer = new CustomerModel();
            Items = new List<OrderItemModel>();
            Seller = new SellerModel();
            ShippingAddress = new AddressModel();
        }

        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public OrderState State { get; set; }

        public CustomerModel Customer { get; set; }

        public IList<OrderItemModel> Items { get; set; }

        public SellerModel Seller { get; set; }

        public AddressModel ShippingAddress { get; set; }

    }
}
