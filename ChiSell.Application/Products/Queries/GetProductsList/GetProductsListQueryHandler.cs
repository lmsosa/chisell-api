using AutoMapper;
using AutoMapper.QueryableExtensions;
using ChiSell.Application.Products.Models;
using ChiSell.Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ChiSell.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductModel>>
    {
        private readonly ChiSellContext _dbContext;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(ChiSellContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ProductModel>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Products
                            .Include(x => x.Seller)
                            .Include(x => x.Brand)
                            .Include(x => x.Category)
                            .ProjectTo<ProductModel>(_mapper.ConfigurationProvider)
                            .ToListAsync(cancellationToken);
        }
    }
}
