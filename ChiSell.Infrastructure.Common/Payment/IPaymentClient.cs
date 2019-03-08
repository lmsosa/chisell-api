using System;
using System.Threading.Tasks;

namespace ChiSell.Infrastructure.Common.Payment
{
    public interface IPaymentClient
    {
        Task<CustomerResult> CreateCustomerAsync(CustomerInfo customerInfo);

        Task<PaymentResult> CreatePaymentAsync(PaymentInfo paymentInfo);
    }
}
