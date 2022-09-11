using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.ClienteRepositories;
using ERP.Domain.Entities.ClienteEntities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Commands.CreateCliente
{
    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, Guid>
    {
        private readonly IClienteRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public CreateClienteCommandHandler(IClienteRepositoryAsync clienteRepository, IMapper mapper)
        {
            _repository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            var cliente = _repository.GetByIdentificacion(request.Identificacion);
            if (cliente is not null) throw new BadRequestException(ApplicationConstants.ClienteConstants.clienteExiste);

            var entity = await _repository.AddClienteAsync(_mapper.Map<Cliente>(request));
            if (entity is null) throw new BadRequestException(ApplicationConstants.GeneralConstants.errorRegistrandoInformacion);
            return (entity.Id);
        }
    }
}