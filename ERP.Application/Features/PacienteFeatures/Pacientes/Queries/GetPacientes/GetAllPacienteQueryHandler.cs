using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.PacienteRepositories;
using ERP.Domain.DTOs.PacienteDto;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.PacienteFeatures.Pacientes.Queries.GetPacientes
{
    public class GetAllPacienteQueryHandler : IRequestHandler<GetAllPacienteQuery, IEnumerable<PacienteDto>>
    {
        private readonly IPacienteRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public GetAllPacienteQueryHandler(IPacienteRepositoryAsync Repository, IMapper mapper)
        {
            _repository = Repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PacienteDto>> Handle(GetAllPacienteQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<IEnumerable<PacienteDto>>(_repository.GetPacientesDetalle());
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return await Task.FromResult(entity);
        }
    }
}
