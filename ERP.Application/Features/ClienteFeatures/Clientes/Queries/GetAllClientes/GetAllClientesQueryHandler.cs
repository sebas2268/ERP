using AutoMapper;
using Domain.DTOs.ClientesDto;
using MediatR;
using MovaltoSegurdidaSocial.Application.Constants;
using MovaltoSegurdidaSocial.Application.Exceptions;
using MovaltoSegurdidaSocial.Application.Interfaces.Repositories.ClienteRepositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MovaltoSegurdidaSocial.Application.Features.ClienteFeatures.Clientes.Queries.GetAllClientes
{
    public class GetAllClientesQueryHandler : IRequestHandler<GetAllClientesQuery, IEnumerable<ClienteDto>>
    {
        private readonly IClienteRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public GetAllClientesQueryHandler(IClienteRepositoryAsync Repository, IMapper mapper)
        {
            _repository = Repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteDto>> Handle(GetAllClientesQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<IEnumerable<ClienteDto>>(await _repository.GetAllAsync());
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return entity;
        }
    }

}
