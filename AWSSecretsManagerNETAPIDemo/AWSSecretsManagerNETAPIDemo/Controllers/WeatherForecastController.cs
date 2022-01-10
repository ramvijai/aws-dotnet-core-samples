using Microsoft.AspNetCore.Mvc;

namespace AWSSecretsManagerNETAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfigSettings _configSettings;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfigSettings configSettings)
        {
            _logger = logger;
            _configSettings = configSettings;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            var result = "key 1 - " + _configSettings.Key1 + " : Key 2 - " + _configSettings.Key2;
            return result;
        }
    }
}