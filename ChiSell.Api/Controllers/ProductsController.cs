using ChiSell.Application.Products.Models;
using ChiSell.Application.Products.Queries.GetProductsList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChiShell.Api.Controllers
{
    /// <summary>
    /// Product Controller
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Fields

        private readonly IMediator _mediator;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="CurriculumController"/>
        /// </summary>
        /// <param name="mediator"></param>
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region Endpoints

        /// <summary>
        /// Returns all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetAll()
        {
            var result = await _mediator.Send(new GetProductsListQuery());
            return result;

        }

        #endregion
    }
}
