using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.ClienteRepositories;
using ERP.Domain.Entities.ClienteEntities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Commands.UpdateCliente
{
    public class UpdateClienteCommandHandler : IRequestHandler<UpdateClienteCommand, Guid>
    {
        private readonly IClienteRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public UpdateClienteCommandHandler(IClienteRepositoryAsync clienteRepository, IMapper mapper)
        {
            _repository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
            var cliente = _mapper.Map(request, _mapper.Map<Cliente>(await _repository.GetByIdAsync(request.Id)));
            if (cliente is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);

            var entity = (await _repository.UpdateClienteAsync(cliente));
            if (entity is null) throw new BadRequestException(ApplicationConstants.GeneralConstants.errorRegistrandoInformacion);
            return entity.Id;
        }
    }
}
