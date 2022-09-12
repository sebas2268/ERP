using ERP.Domain.DTOs.PersonasDto;
using MediatR;

namespace ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaById
{
    public class GetPersonaByIdQuery : IRequest<PersonaDto>
    {
        public int Nmid { get; set; }

        public GetPersonaByIdQuery(int nmid)
        {
            Nmid = nmid;
        }
    }
}
