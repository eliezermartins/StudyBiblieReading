using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Extentions;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasKey(a => new { a.Id, a.BibleId });

        builder.Property(a => a.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.HasOne(b => b.Bible)
            .WithMany(b => b.Articles)
            .HasForeignKey(b => b.BibleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Classification)
            .IsRequired()
            .HasConversion(
                a => a.GetDescription(),
                a => Enum.GetValues(typeof(EArticleGroup))
                         .Cast<EArticleGroup>()
                         .FirstOrDefault(e => e.GetDescription() == a))
            .HasMaxLength(20);

        builder.Property(a => a.SequenceInTheBible)
            .IsRequired();

        builder.Property(a => a.IsRead)
            .IsRequired();
    }
}
