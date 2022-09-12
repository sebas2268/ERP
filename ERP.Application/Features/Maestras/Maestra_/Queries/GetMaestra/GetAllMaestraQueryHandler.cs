using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Domain.DTOs.Maestras;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.Maestras.Maestra_.Queries.GetMaestra
{
    public class GetAllMaestraQueryHandler : IRequestHandler<GetAllMaestraQuery, IEnumerable<MaestraDto>>
    {
        private readonly IMaestraRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public GetAllMaestraQueryHandler(IMaestraRepositoryAsync Repository, IMapper mapper)
        {
            _repository = Repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MaestraDto>> Handle(GetAllMaestraQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<IEnumerable<MaestraDto>>(await _repository.GetAllAsync());
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return entity;
        }
    }
}