using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Services;
using Domain.Repositories;
using MediatR;

namespace Application.Commands.Item.Handlers
{
    public class StockItemStockDownCommandHandler : IRequestHandler<StockItemStockDownCommand>
    {
        private readonly IItemRepository _repository;
        private readonly IEventProcessor _eventProcessor;

        public StockItemStockDownCommandHandler(IItemRepository repository, IEventProcessor eventProcessor)
        {
            _repository = repository;
            _eventProcessor = eventProcessor;
        }

        public async Task<Unit> Handle(StockItemStockDownCommand request, CancellationToken cancellationToken)
        {
             var item = await _repository.GetAsync(request.Id);
            if (item is null) { throw new ItemNotFoundException(request.Id); }
            var updatedItem = Domain.Entities.Item.Pop(item,request.Amount);
            await _repository.UpdateAsync(updatedItem);
            await _eventProcessor.ProcessAsync(updatedItem.Events);
            return Unit.Value;
        }
    }
}
