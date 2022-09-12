using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.PersonaRepositories;
using ERP.Domain.DTOs.PersonasDto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaById
{
    public class GetPersonaQueryHandler : IRequestHandler<GetPersonaByIdQuery, PersonaDto>
    {
        private readonly IPersonaRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public GetPersonaQueryHandler(IPersonaRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PersonaDto> Handle(GetPersonaByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<PersonaDto>(await _repository.GetByIdAsync(request.Nmid));
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return entity;
        }
    }
}