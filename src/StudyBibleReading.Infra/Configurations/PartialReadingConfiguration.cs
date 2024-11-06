using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class PartialReadingConfiguration : IEntityTypeConfiguration<PartialReading>
{
    public void Configure(EntityTypeBuilder<PartialReading> entity)
    {
        entity.HasMany(lp => lp.Books)
            .WithMany(l => l.Readings)
            .UsingEntity<Dictionary<string, object>>(
                "ReadingsBooks",
                j => j.HasOne<Book>()
                    .WithMany()
                    .HasForeignKey("BookId", "BibleId")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j.HasOne<PartialReading>()
                    .WithMany()
                    .HasForeignKey("PartialReadingId")
                    .OnDelete(DeleteBehavior.Cascade));
    }
}
