using AutoMapper;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Domain.Entities.Maestras;

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

        public SqlERPDbContext SqlERPDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}
