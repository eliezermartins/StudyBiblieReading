using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class PlanReadingConfiguration : IEntityTypeConfiguration<PlanReading>
{
    public void Configure(EntityTypeBuilder<PlanReading> builder)
    {
        builder.HasOne(lp => lp.ReadingPlan)
            .WithMany(pl => pl.Readings)
            .HasForeignKey(lp => lp.ReadingPlanId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
