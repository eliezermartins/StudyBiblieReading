using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Extentions;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
{
    public void Configure(EntityTypeBuilder<Translation> builder)
    {
        builder.HasKey(v => v.Id);

        builder.Property(e => e.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.Property(v => v.Description)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(v => v.Acronym)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(l => l.Tradition)
            .IsRequired()
            .HasConversion(
                v => v.GetDescription(),
                v => Enum.GetValues(typeof(ETradition))
                         .Cast<ETradition>()
                         .FirstOrDefault(e => e.GetDescription() == v))
            .HasMaxLength(20);

        builder.HasMany(v => v.Bibles)
            .WithOne(b => b.Translation)
            .HasForeignKey(b => b.TranslationId);

        builder.HasIndex(v => v.Acronym)
            .IsUnique();
    }
}
