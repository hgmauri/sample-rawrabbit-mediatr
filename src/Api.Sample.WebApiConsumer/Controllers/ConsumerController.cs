using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Sample.WebApiConsumer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {
        private readonly ILogger<ConsumerController> _logger;

        public ConsumerController(ILogger<ConsumerController> logger)
        {
            _logger = logger;
        }
    }
}
