using ChiSell.Infrastructure.Common.Exceptions;
using ChiSell.Infrastructure.Common.Payment;
using Microsoft.Extensions.Configuration;
using Stripe;
using System;
using System.Threading.Tasks;

namespace ChiSell.StripeApi
{
    public class StripePaymentClient : IPaymentClient
    {
        private readonly CustomerService _customerService;
        private readonly ChargeService _chargeService;

        public StripePaymentClient(IConfiguration configuration)
        {
            var stripeSecret = configuration.GetValue("StripeSettings:Secret", string.Empty);
            _customerService = new CustomerService(stripeSecret);
            _chargeService = new ChargeService(stripeSecret);
        }

        public async Task<PaymentResult> CreatePaymentAsync(PaymentInfo paymentInfo)
        {
            var amountConverted = (long)paymentInfo.Amount * 100;

            var options = new ChargeCreateOptions
            {
                Amount = amountConverted,
                Currency = paymentInfo.Currency.ToString().ToLower(),
                Description = paymentInfo.Description,
                // TODO: Get Stripe customer id
                CustomerId = paymentInfo.CustomerId.ToString()
            };

            var charge = await _chargeService.CreateAsync(options);
            if (charge == null)
            {
                throw new InfrastructureException("Stripe charge failed");
            }

            return new PaymentResult()
            {
                Identifier = charge.Id,
                Status = charge.Status switch
                {
                    "succeded" => PaymentStatus.Succeded,
                    "failed" => PaymentStatus.Failed,
                    "pending" => PaymentStatus.Pending,
                    _ => PaymentStatus.Unknown
                }
            };

        }

        public async Task<CustomerResult> CreateCustomerAsync(CustomerInfo customerInfo)
        {
            var options = new CustomerCreateOptions
            {
                Description = customerInfo.Name,
                Email = customerInfo.Email
            };

            var customer = await _customerService.CreateAsync(options);
            return new CustomerResult
            {
                Identifier = customer.Id
            };
        }
    }
}
