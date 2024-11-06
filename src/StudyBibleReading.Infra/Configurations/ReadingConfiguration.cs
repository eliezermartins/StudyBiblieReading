using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class ReadingConfiguration : IEntityTypeConfiguration<Reading>
{
    public void Configure(EntityTypeBuilder<Reading> builder)
    {
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.Property(l => l.StartDate)
            .IsRequired();

        builder.Property(l => l.EndDate);

        builder.Property(l => l.Completed)
            .IsRequired();

        // Configuração da herança TPH (Table-per-Hierarchy)
        builder.HasDiscriminator<string>("ReadingType")
              .HasValue<FullReading>("Completa")
              .HasValue<PartialReading>("Parcial")
              .HasValue<PlanReading>("Plano");
    }
}
