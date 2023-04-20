using csharp_webapi_inmemory.efexample.Models;

namespace csharp_webapi_inmemory.efexample.Repository
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync();

        bool DeleteWeatherForecast(int id);
        void AddWeatherForecast(WeatherForecast model);
    }
}
