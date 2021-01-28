
namespace Api.Sample.Domain.Events
{
    public class SampleCreatedEvent : BaseCompletedEvent
    {
        public string Result { get; set; }
    }
}
