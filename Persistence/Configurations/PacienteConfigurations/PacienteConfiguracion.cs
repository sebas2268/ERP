using ERP.Domain.Entities.PacienteEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.PacienteConfigurations
{
    public class PacienteConfiguracion : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("TblPaciente", "General");
            builder.HasKey(e => e.nmid);
            builder.Property(e => e.nmid).
                IsRequired();

            builder.Property(e => e.nmid_persona)
                .IsRequired();

            builder.HasIndex(u => u.nmid_persona)
                .IsUnique();

            builder.Property(e => e.nmid_medicotra)
                .IsRequired();

            builder.Property(e => e.dseps)
                .HasColumnType("VARCHAR(50)");

            builder.Property(e => e.dsarl)
                .HasColumnType("VARCHAR(50)");

            builder.Property(e => e.feregistro)
                .IsRequired(false)
                .HasColumnType("DATETIME");

            builder.Property(e => e.febaja)
                .IsRequired(false)
                .HasColumnType("DATETIME");

            builder.Property(e => e.cdusuario)
                .HasColumnType("VARCHAR(150)");

            builder.Property(e => e.dscondicion)
                .HasColumnType("TEXT");
        }
    }
}
