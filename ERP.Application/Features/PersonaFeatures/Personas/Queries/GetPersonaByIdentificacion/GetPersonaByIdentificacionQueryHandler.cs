using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaByIdentificacion;
using ERP.Application.Interfaces.Repositories.PersonaRepositories;
using ERP.Domain.DTOs.PersonasDto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.PersonaFeatures.Personas.Queries.GetPersonaeByIdentificacion
{
    public class GetPersonaByIdentificacionQueryHandler : IRequestHandler<GetPersonaByIdentificacionQuery, PersonaDto>
    {
        private readonly IPersonaRepositoryAsync _repository;
        private readonly IMapper _mapper;
        public GetPersonaByIdentificacionQueryHandler(IPersonaRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PersonaDto> Handle(GetPersonaByIdentificacionQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<PersonaDto>(_repository.GetByIdentificacion(request.cdDocumento));
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return await Task.FromResult(entity);
        }
    }
}