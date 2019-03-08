using ChiSell.Application.Payments.Models;
using MediatR;
using System.Collections.Generic;

namespace ChiSell.Application.Payments.Queries.GetPaymentsList
{
    public class GetPaymentsListQuery : IRequest<List<PaymentModel>>
    {
    }
}
