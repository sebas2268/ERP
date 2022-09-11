using ERP.Domain.Entities.ClienteEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations
{
    public class ClienteConfiguracion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TblCliente");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).
                IsRequired();

            builder.Property(e => e.FechaRegistro).
                HasColumnType("DATETIME");

            builder.Property(e => e.Identificacion).
                HasColumnType("VARCHAR(30)");

            builder.Property(e => e.Nombre)
                .HasColumnType("VARCHAR(200)");

            builder.Property(e => e.SegundoNombre)
                .HasColumnType("VARCHAR(30)");

            builder.Property(e => e.PrimerApellido)
                .HasColumnType("VARCHAR(30)");

            builder.Property(e => e.SegundoApellido)
                .HasColumnType("VARCHAR(30)");

            builder.Property(e => e.TelefonoContacto1)
                .HasColumnType("VARCHAR(15)");            
            
            builder.Property(e => e.TelefonoContacto2)
                .HasColumnType("VARCHAR(15)");

            builder.Property(e => e.TelefonoContacto2)
                .HasColumnType("VARCHAR(15)");

            builder.Property(e => e.CorreoElectronico)
                .HasColumnType("VARCHAR(60)");
        }
    }
}
