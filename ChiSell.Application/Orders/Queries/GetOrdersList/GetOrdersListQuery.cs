using ChiSell.Application.Orders.Models;
using MediatR;
using System.Collections.Generic;

namespace ChiSell.Application.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrderModel>>
    {
    }
}
