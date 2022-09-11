using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.PersonaRepositories;
using ERP.Domain.Entities.PersonaEntities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.PersonaFeatures.Personas.Commands.CreatePersona
{
    public class CreatePersonaCommandHandler : IRequestHandler<CreatePersonaCommand, int>
    {
        private readonly IPersonaRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public CreatePersonaCommandHandler(IPersonaRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePersonaCommand request, CancellationToken cancellationToken)
        {
            var persona = _repository.GetByIdentificacion(request.cddocumento);
            if (persona is not null) throw new BadRequestException(ApplicationConstants.PersonaConstants.personaExiste);

            var entity = await _repository.AddAsync(_mapper.Map<Persona>(request));
            if (entity is null) throw new BadRequestException(ApplicationConstants.GeneralConstants.errorRegistrandoInformacion);
            await _repository.Save();
            return (entity.nmid);
        }
    }
}