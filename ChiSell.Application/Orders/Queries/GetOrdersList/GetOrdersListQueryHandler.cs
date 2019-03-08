using AutoMapper;
using AutoMapper.QueryableExtensions;
using ChiSell.Application.Orders.Models;
using ChiSell.Application.Orders.Queries.GetOrdersList;
using ChiSell.Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ChiSell.Application.Products.Queries.GetProductsList
{
    public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, List<OrderModel>>
    {
        private readonly ChiSellContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrdersListQueryHandler(ChiSellContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<OrderModel>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Orders
                            .Include(x => x.Seller)
                            .Include(x => x.Customer)
                            .Include(x => x.ShippingAddress)
                            .Include(x => x.Items)
                                .ThenInclude(x => x.Product)
                            .ProjectTo<OrderModel>(_mapper.ConfigurationProvider)
                            .ToListAsync(cancellationToken);
        }
    }
}
