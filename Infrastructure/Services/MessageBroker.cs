using Application.Events;
using Application.Services;
using Infrastructure.Messaging;
using MassTransit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MessageBroker : IMessageBroker
    {
        private readonly RabbitMqSettings _mqOptions;
        private readonly IBus _bus;

        public MessageBroker(RabbitMqSettings mqOptions, IBus bus)
        {
            _mqOptions = mqOptions;
            _bus = bus;
        }

        public Task PublishAsync(params IEvent[] events)
            => PublishAsync(events?.AsEnumerable());

        public async Task PublishAsync(IEnumerable<IEvent> events)
        {
            foreach (var @event in events)
            {
                var type = @event.GetType();
                await _bus.Publish(@event, type);
            }
        }
    }
}