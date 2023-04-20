# C# in memory WebAPI examples

This solution contains two projects:

Essentially both projects use a repository layer between the api and data.

Both projects have 
##csharp-webapi-inmemory.staticexample

This project demonstrates a static WeatherForecastStore class.   This wraps a WeatherForecasts property which is a list of all  
the WeatherForecast items.



##csharp-webapi-inmemory.efexample
This project introduces Entity Framework.  This example has an in memory EF database. The WeatherForecastContext 