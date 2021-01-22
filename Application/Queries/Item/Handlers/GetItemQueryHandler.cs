using System.Threading;
using System.Threading.Tasks;
using Application.DTO;
using Domain.Repositories;
using MediatR;

namespace Application.Queries.Item.Handlers
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemDTO>
    {
        private readonly IItemRepository _repository;

        public GetItemQueryHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ItemDTO> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            var Item = await _repository.GetAsync(request.Id);
            return Item.asItemDTO();
        }
    }
}
