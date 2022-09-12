using ERP.Domain.DTOs.PacienteDto;
using MediatR;
using System.Collections.Generic;

namespace ERP.Application.Features.PacienteFeatures.Pacientes.Queries.GetPacientes
{
    public class GetAllPacienteQuery : IRequest<IEnumerable<PacienteDto>>
    {
    }
}
