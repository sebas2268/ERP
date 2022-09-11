using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.ClienteRepositories;
using AutoMapper;
using ERP.Domain.DTOs.ClientesDto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Queries.GetClienteByIdentificacion
{
    public class GetClienteByIdentificacionQueryHandler : IRequestHandler<GetClienteByIdentificacionQuery, ClienteDto>
    {
        private readonly IClienteRepositoryAsync _repository;
        private readonly IMapper _mapper;
        public GetClienteByIdentificacionQueryHandler(IClienteRepositoryAsync Repository, IMapper mapper)
        {
            _repository = Repository;
            _mapper = mapper;
        }

        public async Task<ClienteDto> Handle(GetClienteByIdentificacionQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ClienteDto>(_repository.GetByIdentificacion(request.Identificacion));
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return await Task.FromResult(entity);
        }
    }
}