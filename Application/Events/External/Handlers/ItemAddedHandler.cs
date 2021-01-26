using Application.Commands.Item;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Events.External.Handlers
{
    public class ItemAddedHandler : IRequestHandler<ItemAdded>
    {
        private readonly IMediator _mediator;

        public ItemAddedHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(ItemAdded request, CancellationToken cancellationToken)
        {
            await _mediator.Send(new CreateStockItemCommand() { Id = request.Id, Amount = 0 });
            return Unit.Value;
        }
    }
}