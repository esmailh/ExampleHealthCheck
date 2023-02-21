using ExampleHealthCheck;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks().AddCheck<MyHealthCheck>("MyHealthCheck");
//.AddCheck<MyHealthCheck>("MyHealthCheck", tags: new[] { "custom" });
builder.Services.AddHealthChecksUI().AddInMemoryStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

//app.MapHealthChecks("/health");

app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

//We map a new Health Check endpoint to /health/custom, and this time we add a Predicate delegate to only return Health Checks that include our custom tag.
//app.MapHealthChecks("/health/custom", new HealthCheckOptions
//{
//    Predicate = reg => reg.Tags.Contains("custom"),
//    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
//});


///healthchecks-ui
app.MapHealthChecksUI();


app.Run();
