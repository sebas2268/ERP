using ERP.Domain.DTOs.ClientesDto;
using MediatR;
using System.Collections.Generic;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Queries.GetClientes
{
    public class GetAllClientesQuery : IRequest<IEnumerable<ClienteDto>>
    {
    }
}
