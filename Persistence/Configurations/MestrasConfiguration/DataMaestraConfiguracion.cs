using ERP.Domain.Entities.Maestras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.MestrasConfiguration
{
    public class DataMaestraConfiguracion : IEntityTypeConfiguration<DataMaestra>
    {
        public void Configure(EntityTypeBuilder<DataMaestra> builder)
        {
            builder.ToTable("TblDataMaestra", "Maestra");
            builder.HasKey(e => e.nmdato);
            builder.Property(e => e.nmdato)
                .HasColumnType("VARCHAR(150)")
                .IsRequired();

            builder.Property(e => e.cddato)
                .HasColumnType("VARCHAR(20)");

            builder.Property(e => e.dsdato)
                .HasColumnType("VARCHAR(100)");

            builder.Property(e => e.cddato1)
                .HasColumnType("VARCHAR(100)");

            builder.Property(e => e.cddato2)
                .HasColumnType("VARCHAR(100)");

            builder.Property(e => e.cddato3)
                .HasColumnType("VARCHAR(100)");

            builder.Property(e => e.feregistro)
                .IsRequired(false)
                .HasColumnType("DATETIME");

            builder.Property(e => e.febaja)
                .IsRequired(false)
                .HasColumnType("DATETIME");
        }
    }
}
