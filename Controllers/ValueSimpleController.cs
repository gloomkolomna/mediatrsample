using MediatR;
using MediatRSample.Requests.Values;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRSample.Controllers
{
    [ApiController]
    [Route("/valuesimple")]
    public class ValueSimpleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValueSimpleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllValue()
        {
            var values = await _mediator.Send(new GetAllValuesQuery());
            if (values == null)
                return NoContent();

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateValue(CreateValueCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
    }
}
