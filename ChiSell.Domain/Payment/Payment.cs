using System;
using ChiSell.Domain.Orders;

namespace ChiSell.Domain.Payment
{
    public class Payment
    {
        public Payment()
        {
            Order = new Order();
        }

        public Guid Id { get; set; }

        public Order Order { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
