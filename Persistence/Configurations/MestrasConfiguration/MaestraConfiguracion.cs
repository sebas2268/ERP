using ERP.Domain.Entities.Maestras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.MestrasConfiguration
{
    public class MaestraConfiguracion : IEntityTypeConfiguration<Maestra>
    {
        public void Configure(EntityTypeBuilder<Maestra> builder)
        {
            builder.ToTable("TblMaestra", "Maestra");
            builder.HasKey(e => e.nmmaestro);
            builder.Property(e => e.nmmaestro)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder.Property(e => e.cdmaestro)
                .HasColumnType("VARCHAR(5)")
                .IsRequired();

            builder.Property(e => e.dsmaestro)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(e => e.feregistro)
                .IsRequired(false)
                .HasColumnType("DATETIME");

            builder.Property(e => e.febaja)
                .IsRequired(false)
                .HasColumnType("DATETIME");
        }
    }
}
