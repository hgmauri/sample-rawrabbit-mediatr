using MediatR;

namespace Api.Sample.Domain.Messaging
{
    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeEvent<TEvent>() where TEvent : IEvent, IRequest;
    }
}
