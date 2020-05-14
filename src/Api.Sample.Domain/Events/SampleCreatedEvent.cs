using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Api.Sample.Domain.Events
{
    public class SampleCreatedEvent : BaseCompletedEvent
    {
        public string Result { get; set; }
    }
}
