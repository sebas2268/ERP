using ERP.Application.Features.PersonaFeatures.Personas.Commands.CreatePersona;
using ERP.Application.Features.PersonaFeatures.Personas.Commands.UpdatePersona;
using ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaById;
using ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaByIdentificacion;
using ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonas;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PersonaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [MapToApiVersion("1.0")]
        [HttpGet("{nmid}")]
        public async Task<IActionResult> Get(int nmid, CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetPersonaByIdQuery(nmid), ct));
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetAllPersonaQuery(), ct));
        }

        [HttpGet("cddocumento/{cddocumento}")]
        public async Task<IActionResult> Get(string cddocumento, CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetPersonaByIdentificacionQuery(cddocumento), ct));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePersonaCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("nmid/{nmid}")]
        public async Task<IActionResult> Put(int nmid, [FromBody] UpdatePersonaCommand command)
        {
            if (nmid != command.nmid)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }
    }
}