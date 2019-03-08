using System;

namespace ChiSell.Infrastructure.Common.Payment
{
    public class PaymentInfo
    {
        public decimal Amount { get; set; }

        public CurrenciesEnum Currency { get; set; }

        public string? Description { get; set; }

        public Guid CustomerId { get; set; }
    }
}
