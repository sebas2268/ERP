using ERP.Application.Interfaces;
using ERP.Domain.Entities.Maestras;
using ERP.Domain.Entities.PacienteEntities;
using ERP.Domain.Entities.PersonaEntities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ERP.Persistence
{
    public class SqlERPDbContext : DbContext, IERPDbContext
    {
        public SqlERPDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Persona> TblPersona { get; set; }
        public DbSet<Paciente> TblPaciente { get; set; }
        public DbSet<Maestra> TblMaestra { get; set; }
        public DbSet<DataMaestra> TblDataMaestra { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlERPDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //All Decimals will have 18,6 Range
            foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,6)");
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}