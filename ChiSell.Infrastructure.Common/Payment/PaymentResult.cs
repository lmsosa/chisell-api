namespace ChiSell.Infrastructure.Common.Payment
{
    public class PaymentResult
    {
        public string Identifier { get; set; } = default!;

        public PaymentStatus Status { get; set; }
    }
}
