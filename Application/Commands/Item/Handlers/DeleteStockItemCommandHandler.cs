using Application.Exceptions;
using Application.Services;
using Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Item.Handlers
{
    public class DeleteStockItemCommandHandler : IRequestHandler<DeleteStockItemCommand>
    {
        private readonly IItemRepository _repository;
        private readonly IEventProcessor _eventProcessor;

        public DeleteStockItemCommandHandler(IItemRepository repository, IEventProcessor eventProcessor)
        {
            _repository = repository;
            _eventProcessor = eventProcessor;
        }

        public async Task<Unit> Handle(DeleteStockItemCommand request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync(request.Id);
            if (item is null) { throw new ItemNotFoundException(request.Id); }
            item.Delete(item);
            await _repository.DeleteAsync(item.Id);
            await _eventProcessor.ProcessAsync(item.Events);
            return Unit.Value;
        }
    }
}