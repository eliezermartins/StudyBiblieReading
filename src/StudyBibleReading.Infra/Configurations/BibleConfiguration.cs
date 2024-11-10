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
            .WithMany(t => t.Bibles)
            .HasForeignKey(b => b.TranslationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Publisher)
            .WithMany(p => p.Bibles)
            .HasForeignKey(b => b.PublisherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(b => b.Pages)
            .IsRequired();

        builder.Property(b => b.Study)
            .IsRequired();

        builder.Property(b => b.ReadingQuantity)
            .IsRequired();

        builder.HasMany(b => b.Books)
            .WithOne(b => b.Bible)
            .HasForeignKey(b => b.BibleId);

        builder.HasMany(b => b.Articles)
            .WithOne(a => a.Bible)
            .HasForeignKey(a => a.BibleId);

        builder.HasMany(b => b.Readings)
            .WithOne(b => b.Bible)
            .HasForeignKey(b => b.BibleId);
    }
}
