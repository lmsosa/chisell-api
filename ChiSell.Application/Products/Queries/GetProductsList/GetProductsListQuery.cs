using ChiSell.Application.Products.Models;
using MediatR;
using System.Collections.Generic;

namespace ChiSell.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery : IRequest<List<ProductModel>>
    {
    }
}
