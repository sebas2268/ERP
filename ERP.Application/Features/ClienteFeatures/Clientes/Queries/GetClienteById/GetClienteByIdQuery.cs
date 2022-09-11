using ERP.Domain.DTOs.ClientesDto;
using MediatR;
using System;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Queries.GetClienteById
{
    public class GetClienteByIdQuery : IRequest<ClienteDto>
    {
        public Guid Id { get; set; }

        public GetClienteByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
