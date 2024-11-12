using Microsoft.EntityFrameworkCore;
using StudyBibleReading.App.Services;
using StudyBibleReading.Domain.UnitOfWork;
using StudyBibleReading.Infra.Context;
using StudyBibleReading.Infra.UnitOfWork;
using StudyBiblieReading.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<SbrContext>(options => options.UseSqlite("Data Source=../../db/SBRDB.sqlite3"));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<PublisherService>();
builder.Services.AddScoped<TranslationService>();

var app = builder.Build();
app.CreateDatabase();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
