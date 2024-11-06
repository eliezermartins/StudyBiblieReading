using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(e => e.Bibles)
            .WithOne(b => b.Publisher)
            .HasForeignKey(b => b.PublisherId);
    }
}
