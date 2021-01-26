using Application.DTO;
using MediatR;
using System.Collections.Generic;

namespace Application.Queries.Item
{
    public class GetAllItemsQuery : IRequest<IEnumerable<ItemDTO>>
    {
    }
}