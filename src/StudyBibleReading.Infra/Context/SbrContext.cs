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

    public DbSet<Article> Articles { get; set; }

    public DbSet<Chapter> Chapters { get; set; }

    public DbSet<Reading> Readings { get; set; }

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

        modelBuilder.ApplyConfiguration(new ApplicationSettingConfiguration());
        modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        modelBuilder.ApplyConfiguration(new TranslationConfiguration());
        modelBuilder.ApplyConfiguration(new BibleConfiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new ChapterConfiguration());
        modelBuilder.ApplyConfiguration(new ArticleConfiguration());
        modelBuilder.ApplyConfiguration(new ReadingConfiguration());
        modelBuilder.ApplyConfiguration(new FullReadingConfiguration());
        modelBuilder.ApplyConfiguration(new PartialReadingConfiguration());
        modelBuilder.ApplyConfiguration(new PlanReadingConfiguration());
        modelBuilder.ApplyConfiguration(new ReadingPlanConfiguration());
        modelBuilder.ApplyConfiguration(new ReadingPlanDayConfiguration());

        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
    }
}
