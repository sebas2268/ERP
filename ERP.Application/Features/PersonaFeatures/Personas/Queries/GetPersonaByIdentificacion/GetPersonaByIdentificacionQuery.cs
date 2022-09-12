using ERP.Domain.DTOs.PersonasDto;
using MediatR;

namespace ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaByIdentificacion
{
    public class GetPersonaByIdentificacionQuery : IRequest<PersonaDto>
    {
        public string cdDocumento { get; set; }
        public GetPersonaByIdentificacionQuery(string cddocumento)
        {
            cdDocumento = cddocumento;
        }
    }
}