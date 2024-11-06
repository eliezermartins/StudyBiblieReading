using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class ReadingPlanConfiguration : IEntityTypeConfiguration<ReadingPlan>
{
    public void Configure(EntityTypeBuilder<ReadingPlan> builder)
    {
        builder.HasKey(pl => pl.Id);

        builder.Property(pl => pl.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.Property(pl => pl.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(pl => pl.Description)
            .HasMaxLength(150);

        builder.Property(v => v.Tradition)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.HasMany(pl => pl.Items)
            .WithOne(pd => pd.ReadingPlan)
            .HasForeignKey(pd => pd.ReadingPlanId);

        builder.HasMany(pl => pl.Readings)
            .WithOne(l => l.ReadingPlan)
            .HasForeignKey(l => l.ReadingPlanId);

        builder.Ignore(pl => pl.ReadingQuantity);
        builder.Ignore(pl => pl.DurationInDays);
        builder.Ignore(pl => pl.DurationInMonths);
        builder.Ignore(pl => pl.DurationInYears);
    }
}
