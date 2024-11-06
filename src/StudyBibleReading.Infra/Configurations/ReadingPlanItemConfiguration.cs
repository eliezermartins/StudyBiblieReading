using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class ReadingPlanItemConfiguration : IEntityTypeConfiguration<ReadingPlanItem>
{
    public void Configure(EntityTypeBuilder<ReadingPlanItem> builder)
    {
        builder.HasKey(pd => new { pd.Id, pd.ReadingPlanId });

        builder.Property(pd => pd.Id)
            .IsRequired();

        builder.HasOne(pd => pd.ReadingPlan)
            .WithMany(pl => pl.Items)
            .HasForeignKey(pd => pd.ReadingPlanId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(pd => pd.Date)
            .IsRequired();

        builder.Property(rp => rp.Read)
            .IsRequired();
    }
}
