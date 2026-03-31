using AzureTest.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger in all environments so APIM can import the spec
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapWeatherForecastEndpoints();

app.Run();
