using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly Settings _options;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILoggerFactory loggerFactory, IOptions<Model.Settings> options)
        {
            _options = options.Value;
            _logger = loggerFactory.CreateLogger<WeatherForecastController>();
            //_config = config;
            var s = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var s1 = s.GetSection("Message");
        }



        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {


            _logger.LogInformation("Start get");
           

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Post()
        {

            var s = AppContext.GetData("Message");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
