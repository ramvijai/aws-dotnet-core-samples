using AWS.Logger;
using AWS.Logger.SeriLog;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AWSLoggerConfig configuration = new AWSLoggerConfig("Serilog.DemoLogGroup");
configuration.Region = "us-west-2";

var logger = new LoggerConfiguration()
.WriteTo.AWSSeriLog(configuration)
.CreateLogger();

builder.Services.AddSingleton<Serilog.ILogger>(logger);

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
