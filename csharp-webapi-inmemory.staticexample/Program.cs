using csharp_webapi_inmemory.staticexample.Data;
using csharp_webapi_inmemory.staticexample.Repository;

var builder = WebApplication.CreateBuilder(args);

//added two lines
builder.Services.AddScoped<IWeatherRepository, WeatherRepository>();
WeatherForecastStore.Initialize();



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
