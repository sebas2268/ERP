using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.PersonaRepositories;
using ERP.Domain.DTOs.PersonasDto;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonas
{
    public class GetAllPersonasQueryHandler : IRequestHandler<GetAllPersonaQuery, IEnumerable<PersonaDto>>
    {
        private readonly IPersonaRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public GetAllPersonasQueryHandler(IPersonaRepositoryAsync Repository, IMapper mapper)
        {
            _repository = Repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonaDto>> Handle(GetAllPersonaQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<IEnumerable<PersonaDto>>(await _repository.GetAllAsync());
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return entity;
        }
    }
}