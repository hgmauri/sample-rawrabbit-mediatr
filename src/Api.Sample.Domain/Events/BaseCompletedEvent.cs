using System;
using Api.Sample.Domain.Messaging;
using MediatR;

namespace Api.Sample.Domain.Events
{
    public class BaseCompletedEvent : IEvent, IRequest
    {
        protected Guid _operationId;
        protected string _origem;
        protected DateTime _data;

        public Guid OperationId
        {
            get
            {
                if (_operationId == Guid.Empty)
                {
                    _operationId = Guid.NewGuid();
                }
                return _operationId;
            }
            set => _operationId = Guid.NewGuid();
        }
        public string Origem
        {
            get
            {
                if (string.IsNullOrEmpty(_origem))
                {
                    _origem = System.Reflection.Assembly.GetEntryAssembly()?.GetName().Name;
                }
                return _origem;
            }
            set => _origem = value;
        }

        public DateTime Data
        {
            get
            {
                if (_data == DateTime.MinValue)
                {
                    _data = DateTime.Now;
                }
                return _data;
            }
            set => _data = value;
        }
    }
}
