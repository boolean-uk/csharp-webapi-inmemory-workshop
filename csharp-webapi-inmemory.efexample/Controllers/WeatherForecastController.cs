using csharp_webapi_inmemory.efexample.Data;
using csharp_webapi_inmemory.efexample.Models;
using csharp_webapi_inmemory.efexample.Repository;
using Microsoft.AspNetCore.Mvc;

namespace csharp_webapi_inmemory.efexample.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
   
    private readonly ILogger<WeatherForecastController> _logger;
    private IWeatherRepository _weatherRepository;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherRepository weatherRepository)
    {
        _logger = logger;
        _weatherRepository = weatherRepository;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public Task<IEnumerable<WeatherForecast>> Get()
    {       
        return _weatherRepository.GetWeatherForecastsAsync(); ;
    }


    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<WeatherForecast> DeleteProduct([FromRoute] int id)
    {
        return _weatherRepository.DeleteWeatherForecast(id) ? Ok() : NotFound();
    }
}
