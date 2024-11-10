using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Extentions;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Infra.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(l => new { l.Id, l.BibleId });

        builder.Property(b => b.Id)
            .HasConversion(
                guid => guid.ToString("N"), // Guid para string sem traços
                str => Guid.Parse(str));

        builder.HasOne(b => b.Bible)
            .WithMany(b => b.Books)
            .HasForeignKey(b => b.BibleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(b => b.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(b => b.Abbreviation)
            .HasMaxLength(5);

        builder.Property(b => b.SequenceInTheBible)
            .IsRequired();

        builder.Property(b => b.Testament)
            .IsRequired()
            .HasConversion(
                v => v.GetDescription(),
                v => Enum.GetValues(typeof(ETestament))
                         .Cast<ETestament>()
                         .FirstOrDefault(e => e.GetDescription() == v))
            .HasMaxLength(20);

        builder.Property(b => b.Classification)
            .IsRequired()
            .HasConversion(
                v => v.GetDescription(),
                v => Enum.GetValues(typeof(EBookGroup))
                         .Cast<EBookGroup>()
                         .FirstOrDefault(e => e.GetDescription() == v))
            .HasMaxLength(20);

        //builder.Property(b => b.Chapters)
        //    .HasConversion(
        //        v => JsonConvert.SerializeObject(v),
        //        v => JsonConvert.DeserializeObject<Dictionary<int, bool>>(v)!)
        //    .Metadata.SetValueComparer(new ValueComparer<IDictionary<int, bool>>(
        //        (d1, d2) => d1!.SequenceEqual(d2!), // Comparar dicionários
        //        d => d.Aggregate(0, (a, v) => HashCode.Combine(a, v.Key.GetHashCode(), v.Value.GetHashCode())), // Gerar hash do dicionário
        //        d => d.ToDictionary(entry => entry.Key, entry => entry.Value))); // Clonar o dicionário
        builder.HasMany(b => b.Chapters)
            .WithOne(b => b.Book)
            .HasForeignKey(b => new { b.BookId, b.BibleId });

        builder.HasMany(b => b.Readings)
            .WithMany(b => b.Books);

        builder.Ignore(b => b.ReadingQuantity);

        builder.HasIndex(b => b.Name);
    }
}
