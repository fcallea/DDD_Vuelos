using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Vuelos.Application.UseCases.Command.Vuelos.CrearVuelo;
using Vuelos.Application.UseCases.Queries.Vuelos.GetVueloById;

namespace Vuelos.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class VueloController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VueloController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearVueloCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }


        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetVueloById([FromRoute] GetVueloByIdQuery command)
        {
            VueloDto result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }
}
