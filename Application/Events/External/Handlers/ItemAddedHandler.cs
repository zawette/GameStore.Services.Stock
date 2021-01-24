using System.Threading;
using System.Threading.Tasks;
using Application.Commands.Item;
using MediatR;

namespace Application.Events.External.Handlers
{
    public class ItemRemovedHandler : IRequestHandler<Application.Events.External.ItemRemoved>
    {
        private readonly IMediator _mediator;

        public ItemRemovedHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(ItemRemoved request, CancellationToken cancellationToken)
        {
            await _mediator.Send(new DeleteItemCommand() { Id = request.Id });
            return Unit.Value;
        }
    }
}