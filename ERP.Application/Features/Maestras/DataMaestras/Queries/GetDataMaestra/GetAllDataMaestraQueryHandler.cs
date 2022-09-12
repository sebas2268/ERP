using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Domain.DTOs.Maestras;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.Maestras.DataMaestras.Queries.GetDataMaestra
{
    public class GetAllDataMaestraQueryHandler : IRequestHandler<GetAllDataMaestraQuery, IEnumerable<DataMaestraDto>>
    {
        private readonly IDataMaestraRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public GetAllDataMaestraQueryHandler(IDataMaestraRepositoryAsync Repository, IMapper mapper)
        {
            _repository = Repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DataMaestraDto>> Handle(GetAllDataMaestraQuery request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<IEnumerable<DataMaestraDto>>(await _repository.GetAllAsync());
            if (entity is null) throw new NotFoundException(ApplicationConstants.GeneralConstants.informacionNoEncontrada);
            return entity;
        }
    }
}