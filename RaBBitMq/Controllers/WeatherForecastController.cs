using MessageBroker.Relatorios;
using Microsoft.AspNetCore.Mvc;

namespace RaBBitMq.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var solicitacao = new SolicitacaoRelatorio() 
            {
                Id = Guid.NewGuid(),
                Nome = "david",
                Status = "Pendente",
                ProcessedTime = null
            };
            var lis = new  Lista();

            lis.Relatorio.Add(solicitacao);

          

            return Ok(lis);
        }
    }
}
