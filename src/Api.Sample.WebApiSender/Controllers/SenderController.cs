using Api.Sample.Domain.Events;
using Api.Sample.Domain.Messaging;
using Microsoft.AspNetCore.Mvc;

namespace Api.Sample.WebApiSender.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SenderController : ControllerBase
    {
        private readonly IBusPublisher _busPublisher;
        public SenderController(IBusPublisher busPublisher)
        {
            _busPublisher = busPublisher;
        }

        public OkResult Sender()
        {
            _busPublisher.PublishAsync(new SampleCreatedEvent { Result = "OK" });
            return Ok();
        }
    }
}
