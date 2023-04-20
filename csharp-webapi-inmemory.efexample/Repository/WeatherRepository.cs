using csharp_webapi_inmemory.efexample.Data;
using csharp_webapi_inmemory.efexample.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_webapi_inmemory.efexample.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        public void AddWeatherForecast(WeatherForecast model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWeatherForecast(int id)
        {
            using (var db = new WeatherForecastContext())
            {
                var model = db.WeatherForecasts.FirstOrDefault(x => x.Id == id);
                if(model!=null)
                {
                    db.WeatherForecasts.Remove(model);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync()
        {
            using (var db = new WeatherForecastContext())
            {
                var list = await db.WeatherForecasts
                    .ToListAsync();
                return list;
            }
        }
      
    }
}
