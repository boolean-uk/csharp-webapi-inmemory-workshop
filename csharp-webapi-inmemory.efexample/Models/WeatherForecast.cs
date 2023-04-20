using System.ComponentModel.DataAnnotations;

namespace csharp_webapi_inmemory.efexample.Models;

public class WeatherForecast
{
    [Key]
    public int Id { get; set; }
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
