using System.Threading.Tasks;

namespace Api.Sample.Domain.Messaging
{
    public interface IBusPublisher
    {
        Task PublishAsync<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
