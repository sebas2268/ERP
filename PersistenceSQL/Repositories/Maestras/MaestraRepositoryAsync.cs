using AutoMapper;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Domain.DTOs.Maestras;
using ERP.Domain.Entities.Maestras;
using System.Linq;

namespace ERP.PersistenceSQL.Repositories.Maestras
{
    public class MaestraRepositoryAsync : GenericRepositoryAsync<Maestra>, IMaestraRepositoryAsync
    {
        private readonly IMapper _mapper;
        public MaestraRepositoryAsync(SqlERPDbContext dbContext, IMapper mapper)
            : base(dbContext)
        {
            _mapper = mapper;
        }

        public MaestraDto GetBynmmaestroMaestra(string nmmaestro)
        {
            return _mapper.Map<MaestraDto>(_dbContext.TblMaestra
                    .Where(a => a.nmmaestro == nmmaestro)
                    .FirstOrDefault());
        }

        public SqlERPDbContext SqlERPDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}
