using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;
using Serilog;
using Prometheus;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddHealthChecks()
    .AddNpgSql(builder.Configuration.GetConnectionString("DefaultConnection")!);
builder.Services.AddCors();

// Logging
builder.Host.UseSerilog((context, config) => 
    config.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

// Middleware
app.UseSerilogRequestLogging();
app.UseCors(policy => policy
    .WithOrigins("http://localhost:3000", "http://nginx")
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseMetricServer();  // /metrics
app.UseHttpMetrics();
app.MapHealthChecks("/health");
app.MapControllers();

// Seed data
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.Run();