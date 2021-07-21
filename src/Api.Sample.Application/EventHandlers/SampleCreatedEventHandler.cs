using System.Threading;
using System.Threading.Tasks;
using Api.Sample.Domain.Events;
using MediatR;
using Serilog;

namespace Api.Sample.Application.EventHandlers
{
    public class SampleCreatedEventHandler : IRequestHandler<SampleCreatedEvent>
    {
        public Task<Unit> Handle(SampleCreatedEvent request, CancellationToken cancellationToken)
        {
            Log.Information($"{nameof(SampleCreatedEvent)} = {request.Result}");

            return Task.FromResult(Unit.Value);
        }
    }
}
