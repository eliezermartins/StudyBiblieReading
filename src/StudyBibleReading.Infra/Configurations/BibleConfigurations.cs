using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class BibleConfiguration : IEntityTypeConfiguration<Bible>
{
    public void Configure(EntityTypeBuilder<Bible> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(150);

        builder.HasOne(b => b.Translation)
            .WithMany(v => v.Bibles)
            .HasForeignKey(b => b.TranslationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Publisher)
            .WithMany(e => e.Bibles)
            .HasForeignKey(b => b.PublisherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(b => b.Pages)
            .IsRequired();

        builder.Property(b => b.Study)
            .IsRequired();

        builder.HasMany(b => b.Books)
            .WithOne(l => l.Bible)
            .HasForeignKey(l => l.BibleId);

        builder.HasMany(b => b.Readings)
                .WithOne(l => l.Bible)
                .HasForeignKey(l => l.BibleId);

        builder.Ignore(b => b.ReadingQuantity);
    }
}
