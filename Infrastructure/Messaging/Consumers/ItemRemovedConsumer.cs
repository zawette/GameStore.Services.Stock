using System.Threading.Tasks;
using Application.Events.External;
using MassTransit;
using MediatR;

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
