using System.Threading.Tasks;
using Application.Events.External;
using MassTransit;
using MediatR;

namespace Infrastructure.Messaging.Consumers
{
    public class ItemAddedConsumer : IConsumer<ItemAdded>
    {
        private readonly IMediator _mediator;

        public ItemAddedConsumer(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Consume(ConsumeContext<ItemAdded> context)
        {
            await _mediator.Send(new ItemAdded(context.Message.Id));
        }
    }
}
