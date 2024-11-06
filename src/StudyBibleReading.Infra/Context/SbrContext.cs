using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Infra.Configurations;

namespace StudyBibleReading.Infra.Context;

public class SbrContext(DbContextOptions<SbrContext> options) : DbContext(options)
{
    public DbSet<ApplicationSetting> ApplicationSettings { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<Translation> Translations { get; set; }

    public DbSet<Bible> Bibles { get; set; }

    public DbSet<Book> Books { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    if (optionsBuilder.IsConfigured)
    //    {
    //        return;
    //    }

    //    optionsBuilder.UseSqlite("Data Source=StudyBibleReading.sqlite");
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new BibleConfiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        modelBuilder.ApplyConfiguration(new TranslationConfiguration());
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
    }
}
