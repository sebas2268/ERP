using ERP.Domain.DTOs.Maestras;
using ERP.Domain.Entities.Maestras;

namespace ERP.Application.Interfaces.Repositories.Maestras
{
    public interface IDataMaestraRepositoryAsync : IGenericRepositoryAsync<DataMaestra>
    {
        public DataMaestraDto GetBynmdatoDataMaestra(string nmdato);
    }
}
