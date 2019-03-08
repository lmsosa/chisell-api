using ChiSell.Domain.Products;
using System;

namespace ChiSell.Domain.Orders
{
    /// <summary>
    /// Order item
    /// </summary>
    public class OrderItem
    {
        public Guid Id { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public Guid OrderId { get; set; }
    }
}
