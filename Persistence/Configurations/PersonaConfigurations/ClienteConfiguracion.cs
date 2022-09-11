using ERP.Domain.Entities.PersonaEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations
{
    public class PersonaConfiguracion : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("TblPersona", "General");
            builder.HasKey(e => e.nmid);
            builder.Property(e => e.nmid).
                IsRequired();

            builder.Property(e => e.cddocumento)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");

            builder.Property(e => e.dsnombres)
                .IsRequired()
                .HasColumnType("VARCHAR(60)");

            builder.Property(e => e.dsapellidos)
                .HasColumnType("VARCHAR(60)");

            builder.Property(e => e.fenacimiento)
                .IsRequired()
                .HasColumnType("DATE");

            builder.Property(e => e.cdtipo)
                .HasColumnType("VARCHAR(10)");

            builder.Property(e => e.cdgenero)
                .HasColumnType("VARCHAR(10)");

            builder.Property(e => e.feregistro)
                .HasColumnType("DATETIME(0)");

            builder.Property(e => e.febaja)
                .HasColumnType("DATETIME(0)");            
            
            builder.Property(e => e.cdusuario)
                .HasColumnType("VARCHAR(150)");

            builder.Property(e => e.dsdireccion)
                .HasColumnType("VARCHAR(200)");

            builder.Property(e => e.dsphoto)
                .HasColumnType("VARCHAR(500)");

            builder.Property(e => e.cdtelfono_fijo)
                .HasColumnType("VARCHAR(20)");

            builder.Property(e => e.cdtelefono_movil)
                .HasColumnType("VARCHAR(20)");

            builder.Property(e => e.dsemail)
                .HasColumnType("VARCHAR(200)");
        }
    }
}
