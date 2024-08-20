using Microsoft.AspNetCore.Mvc;
using WellBe.Business.Common;
using WellBe.Business.Profissionais;

namespace WellBe.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public Task<string> ObterDadosDoProfissionalAsync(string CPF)
    {
        throw new NotImplementedException();
    }
}
