using csharp_webapi_inmemory.staticexample.Data;
using csharp_webapi_inmemory.staticexample.Models;

namespace csharp_webapi_inmemory.staticexample.Repository
{
    public interface IWeatherRepository
    {
        List<WeatherForecast> GetWeatherForecasts();

        bool DeleteWeatherForecast(int id);
        void AddWeatherForecast(WeatherForecast model);
       

    }
}
