using ChiSell.Application.Customers.Models;
using ChiSell.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChiSell.Application.Orders.Models
{
    public class OrderModel
    {
        public OrderModel()
        {
            CustomerModel = new CustomerModel();
        }

        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public OrderState State { get; set; }

        public CustomerModel CustomerModel { get; set; }
    }
}
