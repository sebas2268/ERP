using ERP.Application.Features.PacienteFeatures.Pacientes.Commands.CreatePaciente;
using ERP.Application.Features.PacienteFeatures.Pacientes.Queries.GetPacientes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Api.Controllers.Paciente
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PacienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetAllPacienteQuery(), ct));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePacienteCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
