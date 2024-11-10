using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
{
    public void Configure(EntityTypeBuilder<Chapter> builder)
    {
        builder.HasKey(c => new { c.Id, c.BookId, c.BibleId });

        builder.Property(c => c.IsRead)
            .IsRequired();

        builder.HasOne(c => c.Book)
            .WithMany(b => b.Chapters)
            .HasForeignKey(b => new { b.BookId, b.BibleId })
            .OnDelete(DeleteBehavior.Cascade);
    }
}
