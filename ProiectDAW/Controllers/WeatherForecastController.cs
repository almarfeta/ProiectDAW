using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProiectDAW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };*/

        private List<string> Summaries = new List<string>
        { 
             "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /*[HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/

        [HttpGet("GetSummary")]
        public ActionResult<List<string>> GetSummary()
        {
            return Ok(Summaries);
        }

        [HttpGet("GetType")]
        public string GetType([FromQuery] string type)
        {
            var weatherGood = "good";
            return weatherGood;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string type)
        {
            var list = new List<string> { "ceva", "inca ceva" };
            list.Add(type);

            return Ok(list);
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            Summaries = new List<string> { "Warm", "Hot" };

            return Ok(Summaries);
        }

        [HttpDelete("Delete/{type}")]
        public async Task<IActionResult> Delete([FromRoute] string type)
        {
            Summaries.Remove(type);

            return Ok(Summaries);
        }

        // CRUD = Create Read Update Delete
        // Operatie - echivalent in postman
        // Create - Post
        // Read - Get
        // Update - Put
        // Delete - Delete

        // Diferenta dintre GET si POSTE este ca in GET parametrii sunt trimisi in URL, pe cand
        //in POST sunt trimisi prin BODY, astfel se pot trimite parole, BODY-ul fiind securizat

    }
}
