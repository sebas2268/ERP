using ERP.Application.Features.Maestras.DataMaestras.Commands.CreateMaestra;
using ERP.Application.Features.Maestras.Maestra_.Queries.GetMaestra;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Api.Controllers.Maestras.DataMaestra
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class MaestraController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MaestraController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetAllMaestraQuery(), ct));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateMaestraCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
