using csharp_webapi_inmemory.staticexample.Data;
using csharp_webapi_inmemory.staticexample.Models;

namespace csharp_webapi_inmemory.staticexample.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        
        /// <summary>
        /// Get all WeatherForecasts
        /// </summary>        
        public List<WeatherForecast> GetWeatherForecasts()
        {
            return WeatherForecastStore.WeatherForecasts;
        }


        /// <summary>
        /// method to delete a WeatherForecast
        /// </summary>
        /// <param name="id">id of the WeatherForecast to delete</param>
        /// <returns></returns>
        public bool DeleteWeatherForecast(int id)
        {
            var model = WeatherForecastStore.WeatherForecasts.Where(i => i.Id == id).FirstOrDefault();
            if (model != null)
            {
                WeatherForecastStore.WeatherForecasts.Remove(model);
                return true;
            }
            return false;
        }
        /// <summary>
        /// method to add a WeatherForecast to our memory store
        /// </summary>
        /// <param name="model"></param>
        public void AddWeatherForecast(WeatherForecast model)
        {
            model.Id = WeatherForecastStore.WeatherForecasts.Count + 1;
            WeatherForecastStore.WeatherForecasts.Add(model);
        }       
    }
}
