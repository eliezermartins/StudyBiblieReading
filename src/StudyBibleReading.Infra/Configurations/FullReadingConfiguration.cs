using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class FullReadingConfiguration : IEntityTypeConfiguration<FullReading>
{
    public void Configure(EntityTypeBuilder<FullReading> builder)
    {
        builder.HasOne(lc => lc.Bible)
            .WithMany(b => b.Readings)
            .HasForeignKey(e => e.BibleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
