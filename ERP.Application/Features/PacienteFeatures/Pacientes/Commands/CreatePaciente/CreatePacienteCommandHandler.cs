using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.PacienteRepositories;
using ERP.Domain.Entities.PacienteEntities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.PacienteFeatures.Pacientes.Commands.CreatePaciente
{
    public class CreatePacienteCommandHandler : IRequestHandler<CreatePacienteCommand, int>
    {
        private readonly IPacienteRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public CreatePacienteCommandHandler(IPacienteRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePacienteCommand request, CancellationToken cancellationToken)
        {
            var paciente = _repository.GetByNmidPaciente(request.nmid_persona);
            if (paciente is not null) throw new BadRequestException(ApplicationConstants.PersonaConstants.personaExiste);

            var entity = await _repository.AddAsync(_mapper.Map<Paciente>(request));
            if (entity is null) throw new BadRequestException(ApplicationConstants.GeneralConstants.errorRegistrandoInformacion);
            await _repository.Save();
            return (entity.nmid);
        }
    }
}
