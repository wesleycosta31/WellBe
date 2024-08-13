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
    public Task<ProfissionalDto> ObterDadosDoProfissionalAsync(string CPF)
    {
        var profissional = _repositorioDeProfissional.ObterDadosDoProfissionalAsync(CPF);

        return new ProfissionalDto
        {
            IdProfissional = profissional.Id,
            Nome = profissional.Nome,
            CPF = profissional.CPF
        };
    }
}
