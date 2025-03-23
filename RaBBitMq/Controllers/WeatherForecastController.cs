using MassTransit;
using MessageBroker.Relatorios;
using Microsoft.AspNetCore.Mvc;

namespace RaBBitMq.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IBus _bus;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IBus bus)
        {
            _logger = logger;
            _bus = bus;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
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

            var eventResquest = new RelatorioSolicitadoEvent(solicitacao.Id, solicitacao.Nome);

            await _bus.Publish(eventResquest); // eventos te o custume de trabalar nomes no passado 
          

            return Ok(lis);
        }
    }
}
