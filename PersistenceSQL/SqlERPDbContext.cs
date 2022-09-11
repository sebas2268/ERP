using Microsoft.EntityFrameworkCore;


namespace ERP.PersistenceSQL
{
    public class SqlERPDbContext : Persistence.SqlERPDbContext
    {
        public SqlERPDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
