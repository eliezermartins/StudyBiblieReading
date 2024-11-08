using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Extentions;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(l => new { l.Id, l.BibleId });

        builder.Property(l => l.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.HasOne(l => l.Bible)
            .WithMany(b => b.Books)
            .HasForeignKey(l => l.BibleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(l => l.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(l => l.Abbreviation)
            .HasMaxLength(5);

        builder.Property(l => l.SequenceInTheBible)
            .IsRequired();

        builder.Property(l => l.Testament)
            .IsRequired()
            .HasConversion(
                v => v.GetDescription(),
                v => Enum.GetValues(typeof(ETestament))
                         .Cast<ETestament>()
                         .FirstOrDefault(e => e.GetDescription() == v))
            .HasMaxLength(20);

        builder.Property(l => l.Classification)
            .IsRequired()
            .HasConversion(
                v => v.GetDescription(),
                v => Enum.GetValues(typeof(EBookGroup))
                         .Cast<EBookGroup>()
                         .FirstOrDefault(e => e.GetDescription() == v))
            .HasMaxLength(20);

        builder.Property(b => b.Chapters)
            .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<int, bool>>(v)!)
            .Metadata.SetValueComparer(new ValueComparer<IDictionary<int, bool>>(
                (d1, d2) => d1!.SequenceEqual(d2!), // Comparar dicionários
                d => d.Aggregate(0, (a, v) => HashCode.Combine(a, v.Key.GetHashCode(), v.Value.GetHashCode())), // Gerar hash do dicionário
                d => d.ToDictionary(entry => entry.Key, entry => entry.Value))); // Clonar o dicionário

        builder.HasMany(l => l.Readings)
            .WithMany(l => l.Books);

        builder.Ignore(l => l.IsRead);

        builder.HasIndex(l => l.Name);
    }
}
