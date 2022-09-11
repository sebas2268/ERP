using ERP.Domain.DTOs.PersonasDto;
using MediatR;
using System;

namespace ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaById
{
    public class GetPersonaByIdQuery : IRequest<PersonaDto>
    {
        public Guid Id { get; set; }

        public GetPersonaByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
