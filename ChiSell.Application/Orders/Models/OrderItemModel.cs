using ChiSell.Application.Products.Models;
using System;

namespace ChiSell.Application.Orders.Models
{
    public class OrderItemModel
    {
        public Guid Id { get; set; }

        public ProductModel? Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public Guid OrderId { get; set; }
    }
}
