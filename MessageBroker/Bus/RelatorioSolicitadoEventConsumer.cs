using MassTransit;
using MessageBroker.Relatorios;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBroker.Bus
{
    public sealed class RelatorioSolicitadoEventConsumer : IConsumer<RelatorioSolicitadoEvent>
    {
        private readonly ILogger<RelatorioSolicitadoEventConsumer> _logger;

        public RelatorioSolicitadoEventConsumer(ILogger<RelatorioSolicitadoEventConsumer> logger)
        {
            _logger = logger;
           
        }
        public Task Consume(ConsumeContext<RelatorioSolicitadoEvent> context) 
        {
            var messagem = context.Message;
            _logger.LogInformation("Processando Relatorios Id:{Id}, Nome{Nome},", messagem.Id, messagem.Nome);

            return Task.CompletedTask;
        }
    }
}
