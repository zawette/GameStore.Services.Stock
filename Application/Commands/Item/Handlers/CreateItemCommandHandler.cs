using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Services;
using Domain.Repositories;
using MediatR;

namespace Application.Commands.Item.Handlers
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand>
    {
        private readonly IItemRepository _repository;
        private readonly IEventProcessor _eventProcessor;

        public CreateItemCommandHandler(IItemRepository repository, IEventProcessor eventProcessor)
        {
            _repository = repository;
            _eventProcessor = eventProcessor;
        }

        public async Task<Unit> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            if (await _repository.ExistsAsync(request.Id)) { throw new ItemAlreadyExistsException(request.Id); }
            var item = Domain.Entities.Item.Create(request.Id, request.Amount);
            await _repository.AddAsync(item);
            await _eventProcessor.ProcessAsync(item.Events);
            return Unit.Value;
        }
    }
}