using ERP.Domain.DTOs.Maestras;
using MediatR;
using System.Collections.Generic;

namespace ERP.Application.Features.Maestras.Maestra_.Queries.GetMaestra
{
    public class GetAllMaestraQuery : IRequest<IEnumerable<MaestraDto>>
    {
    }
}