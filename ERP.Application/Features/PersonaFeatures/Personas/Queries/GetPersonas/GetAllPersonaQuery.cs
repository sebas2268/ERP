using ERP.Domain.DTOs.PersonasDto;
using MediatR;
using System.Collections.Generic;

namespace ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonas
{
    public class GetAllPersonaQuery : IRequest<IEnumerable<PersonaDto>>
    {
    }
}
