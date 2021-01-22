using MediatR;
using System.Collections.Generic;
using Application.DTO;

namespace Application.Queries.Item
{
    public class GetAllItemsQuery : IRequest<IEnumerable<ItemDTO>>
    {
    }
}
