using csharp_webapi_inmemory.staticexample.Models;
using csharp_webapi_inmemory.staticexample.Repository;
using Microsoft.AspNetCore.Mvc;

namespace csharp_webapi_inmemory.staticexample.Controllers;

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
    public IEnumerable<WeatherForecast> Get()
    {
        return _weatherRepository.GetWeatherForecasts();
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

