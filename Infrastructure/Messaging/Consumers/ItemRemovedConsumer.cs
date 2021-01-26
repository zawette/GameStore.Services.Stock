using Application.Events;
using MassTransit;
using MediatR;
using System.Threading.Tasks;

namespace Infrastructure.Messaging.Consumers
{
    public class ItemRemovedConsumer : IConsumer<ItemRemoved>
    {
        private readonly IMediator _mediator;

        public ItemRemovedConsumer(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Consume(ConsumeContext<ItemRemoved> context)
        {
            await _mediator.Send(new ItemRemoved(context.Message.Id));
        }
    }
}