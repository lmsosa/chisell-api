using ChiSell.Application.Payments.Models;
using ChiSell.Application.Payments.Queries.GetPaymentsList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChiShell.Api.Controllers
{
    /// <summary>
    /// Payments Controller
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        #region Fields

        private readonly IMediator _mediator;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="PaymentsController"/>
        /// </summary>
        /// <param name="mediator"></param>
        public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region Endpoints

        /// <summary>
        /// Returns all Payments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PaymentModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PaymentModel>>> GetAll()
        {
            var result = await _mediator.Send(new GetPaymentsListQuery());
            return result;
        }

        #endregion
    }
}
