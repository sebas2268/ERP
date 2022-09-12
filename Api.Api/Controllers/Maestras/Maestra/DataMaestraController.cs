using ERP.Application.Features.Maestras.DataMaestras.Queries.GetDataMaestra;
using ERP.Application.Features.Maestras.Maestra_.Commands.CreateDataMaestra;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Api.Controllers.Maestras.Maestra
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DataMaestraController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DataMaestraController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken ct)
        {
            return Ok(await _mediator.Send(new GetAllDataMaestraQuery(), ct));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDataMaestraCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

    }
}
