using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Features.Maestras.DataMaestras.Commands.CreateMaestra;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Domain.Entities.Maestras;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.Maestras.Maestra_.Commands.CreateDataMaestra
{
    public class CreateDataMaestraCommandHandler : IRequestHandler<CreateDataMaestraCommand, int>
    {
        private readonly IDataMaestraRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public CreateDataMaestraCommandHandler(IDataMaestraRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDataMaestraCommand request, CancellationToken cancellationToken)
        {
            var dataMaestra = _repository.GetBynmdatoDataMaestra(request.nmdato);
            if (dataMaestra is not null) throw new BadRequestException(ApplicationConstants.MaestraConstants.dataMaestraExiste);

            var entity = await _repository.AddAsync(_mapper.Map<DataMaestra>(request));
            if (entity is null) throw new BadRequestException(ApplicationConstants.GeneralConstants.errorRegistrandoInformacion);
            return (await _repository.Save());
        }
    }
}
