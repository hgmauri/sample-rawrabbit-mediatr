using System.Threading.Tasks;
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

        public async Task<OkResult> Sender()
        {
            await _busPublisher.PublishAsync(new SampleCreatedEvent { Result = "OK" });
            return Ok();
        }
    }
}
