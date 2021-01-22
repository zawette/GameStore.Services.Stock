using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Repositories;
using MediatR;
using System.Linq;
using Application.DTO;

namespace Application.Queries.Item.Handlers
{
    public class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, IEnumerable<ItemDTO>>
    {
        private IItemRepository _repository;

        public GetAllItemsQueryHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ItemDTO>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var Items = await _repository.GetAllAsync();
            return Items.Select(i => i.asItemDTO());
        }
    }
}
