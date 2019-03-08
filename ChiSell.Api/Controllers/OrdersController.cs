using ChiSell.Application.Orders.Models;
using ChiSell.Application.Orders.Queries.GetOrdersList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChiShell.Api.Controllers
{
    /// <summary>
    /// Orders Controller
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        #region Fields

        private readonly IMediator _mediator;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="OrdersController"/>
        /// </summary>
        /// <param name="mediator"></param>
        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region Endpoints

        /// <summary>
        /// Returns all Orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<OrderModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetAll()
        {
            var result = await _mediator.Send(new GetOrdersListQuery());
            return result;
        }

        #endregion
    }
}
