# C# in memory WebAPI examples

This solution contains two projects:

Essentially both projects use a repository layer between the api and data.


## csharp-webapi-inmemory.staticexample  

This project holds api data in the static WeatherForecastStore class.   This wraps a WeatherForecasts property which is a list of all  
the WeatherForecast items.


## csharp-webapi-inmemory.efexample  

This project introduces Entity Framework.  This project holds api data using the Entity framwork in memory database. 
