using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StudyBibleReading.Infra.Context;

public class SbrContextFactory : IDesignTimeDbContextFactory<SbrContext>
{
    public SbrContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SbrContext>();
        optionsBuilder.UseSqlite("Data Source=../../db/StudyBookReading_dev.db");

        return new SbrContext(optionsBuilder.Options);
    }
}
