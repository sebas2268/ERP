using AutoMapper;
using ERP.Application.Constants;
using ERP.Application.Exceptions;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Domain.Entities.Maestras;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Application.Features.Maestras.DataMaestras.Commands.CreateMaestra
{
    public class CreateMaestraCommandHandler : IRequestHandler<CreateMaestraCommand, int>
    {
        private readonly IMaestraRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public CreateMaestraCommandHandler(IMaestraRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateMaestraCommand request, CancellationToken cancellationToken)
        {
            var maestra = _repository.GetBynmmaestroMaestra(request.nmmaestro);
            if (maestra is not null) throw new BadRequestException(ApplicationConstants.MaestraConstants.maestraExiste);

            var entity = await _repository.AddAsync(_mapper.Map<Maestra>(request));
            if (entity is null) throw new BadRequestException(ApplicationConstants.GeneralConstants.errorRegistrandoInformacion);
            return (await _repository.Save());
        }
    }
}
