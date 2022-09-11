using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.ClienteRepositories;
using AutoMapper;
using ERP.Domain.DTOs.ClientesDto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Queries.GetClienteById
{
    public class GetClienteQueryHandler : IRequestHandler<GetClienteByIdQuery, ClienteDto>
    {
        private readonly IClienteRepositoryAsync _clienteRepository;
        private readonly IMapper _mapper;

        public GetClienteQueryHandler(IClienteRepositoryAsync clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ClienteDto> Handle(GetClienteByIdQuery request, CancellationToken cancellationToken)
        {
            var cliente = _mapper.Map<ClienteDto>(await _clienteRepository.GetByIdAsync(request.Id));
            if (cliente is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return cliente;
        }
    }
}