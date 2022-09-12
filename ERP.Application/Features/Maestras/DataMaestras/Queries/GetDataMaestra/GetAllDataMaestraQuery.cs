using ERP.Domain.DTOs.Maestras;
using MediatR;
using System.Collections.Generic;

namespace ERP.Application.Features.Maestras.DataMaestras.Queries.GetDataMaestra
{
    public class GetAllDataMaestraQuery : IRequest<IEnumerable<DataMaestraDto>>
    {
    }
}
