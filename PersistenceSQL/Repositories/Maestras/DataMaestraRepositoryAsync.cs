using AutoMapper;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Domain.DTOs.Maestras;
using ERP.Domain.Entities.Maestras;
using System.Linq;

namespace ERP.PersistenceSQL.Repositories.Maestras
{
    public class DataMaestraRepositoryAsync : GenericRepositoryAsync<DataMaestra>, IDataMaestraRepositoryAsync
    {
        private readonly IMapper _mapper;
        public DataMaestraRepositoryAsync(SqlERPDbContext dbContext, IMapper mapper)
            : base(dbContext)
        {
            _mapper = mapper;
        }

        public DataMaestraDto GetBynmdatoDataMaestra(string nmdato)
        {
            return _mapper.Map<DataMaestraDto>(_dbContext.TblDataMaestra
                    .Where(a => a.nmdato == nmdato)
                    .FirstOrDefault());
        }

        public SqlERPDbContext SqlERPDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}
