using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.PersonaRepositories;
using ERP.Domain.Entities.PersonaEntities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.PersonaFeatures.Personas.Commands.UpdatePersona
{
    public class UpdatePersonaCommandHandler : IRequestHandler<UpdatePersonaCommand, int>
    {
        private readonly IPersonaRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public UpdatePersonaCommandHandler(IPersonaRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdatePersonaCommand request, CancellationToken cancellationToken)
        {
            var persona = _mapper.Map(request, _mapper.Map<Persona>(await _repository.GetByIdAsync(request.nmid)));
            if (persona is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);

            var entity = _repository.Update(persona);
            if (entity is null) throw new BadRequestException(ApplicationConstants.GeneralConstants.errorRegistrandoInformacion);
            await _repository.Save();
            return await Task.FromResult(entity.nmid);
        }
    }
}
