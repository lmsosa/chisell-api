using AutoMapper;
using AutoMapper.QueryableExtensions;
using ChiSell.Application.Payments.Models;
using ChiSell.Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ChiSell.Application.Payments.Queries.GetPaymentsList
{
    public class GetPaymentsListQueryHandler : IRequestHandler<GetPaymentsListQuery, List<PaymentModel>>
    {
        private readonly ChiSellContext _dbContext;
        private readonly IMapper _mapper;

        public GetPaymentsListQueryHandler(ChiSellContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PaymentModel>> Handle(GetPaymentsListQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Payments
                            .ProjectTo<PaymentModel>(_mapper.ConfigurationProvider)
                            .ToListAsync(cancellationToken);
        }
    }
}
