using csharp_webapi_inmemory.staticexample.Models;

namespace csharp_webapi_inmemory.staticexample.Data
{
    public static class WeatherForecastStore
    {        
        static string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };


        public static List<WeatherForecast> WeatherForecasts = new List<WeatherForecast>();


        /// <summary>
        /// method to generate lots of weatherforecast objects for our memory store
        /// </summary>
        public static void Initialize()
        {           
            for (int i = 1; i <= 2; i++)
            {
                WeatherForecasts.Add(new WeatherForecast
                {
                    Id = i,
                    Date = new DateOnly(2023, Random.Shared.Next(1, 12), Random.Shared.Next(1, 28)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                });
            }                           
        }
    }
}
