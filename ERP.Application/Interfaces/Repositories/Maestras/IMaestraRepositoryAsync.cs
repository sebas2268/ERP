using ERP.Domain.DTOs.Maestras;
using ERP.Domain.Entities.Maestras;

namespace ERP.Application.Interfaces.Repositories.Maestras
{
    public interface IMaestraRepositoryAsync : IGenericRepositoryAsync<Maestra>
    {
        public MaestraDto GetBynmmaestroMaestra(string nmmaestro);
    }
}
