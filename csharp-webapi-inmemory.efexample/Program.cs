using csharp_webapi_inmemory.efexample.Data;
using csharp_webapi_inmemory.efexample.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//added two lines
builder.Services.AddScoped<IWeatherRepository, WeatherRepository>(); //magically turns an IWeatherRepository into an WeatherRepository instance
builder.Services.AddDbContext<WeatherForecastContext>(opt => opt.UseInMemoryDatabase("WeatherForecastDb"));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
