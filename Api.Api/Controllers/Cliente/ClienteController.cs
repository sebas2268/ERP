using ERP.Application.Features.ClienteFeatures.Clientes.Commands.CreateCliente;
using ERP.Application.Features.ClienteFeatures.Clientes.Commands.UpdateCliente;
using ERP.Application.Features.ClienteFeatures.Clientes.Queries.GetClienteById;
using ERP.Application.Features.ClienteFeatures.Clientes.Queries.GetClienteByIdentificacion;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [MapToApiVersion("1.0")]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id, CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetClienteByIdQuery(id), ct));
        }

        //[HttpGet]
        //public async Task<IActionResult> Get(CancellationToken ct)
        //{
        //    return Ok(await _mediator.Send(new GetAllClientesQuery(), ct));
        //}

        [HttpGet("identificacion/{identificacion}")]
        public async Task<IActionResult> Get(string identificacion, CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetClienteByIdentificacionQuery(identificacion), ct));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClienteCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("clienteId/{clienteId}")]
        public async Task<IActionResult> PutActivarAfiliacion(Guid clienteId, [FromBody] UpdateClienteCommand command)
        {
            if (clienteId != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }
    }
}