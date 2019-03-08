using System;

namespace ChiSell.Infrastructure.Common.Payment
{
    public class CustomerInfo
    {
        public Guid CustomerId { get; set; }

        public string Name { get; set; } = default!;

        public string Email { get; set; } = default!;
    }
}
