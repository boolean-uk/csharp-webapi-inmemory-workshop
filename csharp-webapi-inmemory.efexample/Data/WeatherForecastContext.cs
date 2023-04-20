using csharp_webapi_inmemory.efexample.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace csharp_webapi_inmemory.efexample.Data
{
    public class WeatherForecastContext : DbContext
    {
        static string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        public WeatherForecastContext()
        {
            this.Database.EnsureCreated();
        }
        public WeatherForecastContext(DbContextOptions<WeatherForecastContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "WeatherForecastDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasData(GenerateWeatherForecasts());

        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public List<WeatherForecast> GenerateWeatherForecasts()
        {
            List<WeatherForecast> results = new List<WeatherForecast>();
            for (int i = 1; i <= 5; i++)
            {
                results.Add(new WeatherForecast
                {
                    Id = i,
                    Date = new DateOnly(2023, Random.Shared.Next(1, 12), Random.Shared.Next(1, 28)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                });
            }
            return results;

        }
    }       
}
