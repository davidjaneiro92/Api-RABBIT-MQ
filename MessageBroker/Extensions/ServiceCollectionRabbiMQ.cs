using MassTransit;
using MessageBroker.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MessageBroker.Extensions
{
    public static class ServiceCollectionRabbiMQ
    {
        public static void AddRabbitMQService(this IServiceCollection service)
        {
            service.AddMassTransit(busConfigurator =>
            {
                busConfigurator.AddConsumer<RelatorioSolicitadoEventConsumer>();

                busConfigurator.UsingRabbitMq((ctx, cfg) =>
                {
                    cfg.Host(new Uri("amqp://localhost:5672"), host =>
                    {
                        host.Username("guest");
                        host.Password("guest");
                    });

                    cfg.ConfigureEndpoints(ctx);
                });
            });
        }
    }
}
