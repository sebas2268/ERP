using ERP.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ERP.PersistenceSQL
{
    public class SqlContextFactory : IDesignTimeDbContextFactory<SqlERPDbContext>
    {
        private const string ConnectionStringName = "MovinfoConnection";
        private const string MigrationsAssembly = "PersistenceSQL";

        public SqlERPDbContext CreateDbContext(string[] args)
        {
            //string ConnectionStringName = Environment.GetEnvironmentVariable("MovinfoConnectionDesarrollo");

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.local.json", true)
                .Build();

            var builder = new DbContextOptionsBuilder<ERP.Persistence.SqlERPDbContext>();
            builder.UseSqlServer(
                config.GetConnectionString(ConnectionStringName),
                b => b.MigrationsAssembly(MigrationsAssembly)
            );


            return new SqlERPDbContext(builder.Options);
        }
    }
}
