using System.Threading.Tasks;
using Api.Sample.Domain.Messaging;
using RawRabbit;
using RawRabbit.Configuration.Exchange;

namespace Api.Sample.Infrastructure.RabbitMq
{
    public class BusPublisher : IBusPublisher
    {
        private readonly IBusClient _busClient;

        public BusPublisher(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task PublishAsync<TEvent>(TEvent @event) where TEvent : IEvent
        {
            await _busClient.PublishAsync(@event, ctx => ctx
                .UsePublishConfiguration(cfg => cfg 
                    .OnDeclaredExchange(e => e
                        .WithName("sample-rabbitmq-publish")
                        .WithType(ExchangeType.Topic))
                    .WithRoutingKey(typeof(TEvent).Name)));
        }
    }
}
