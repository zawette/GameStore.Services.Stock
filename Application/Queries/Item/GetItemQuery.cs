using System;
using Application.DTO;
using MediatR;

namespace Application.Queries.Item
{
    public class GetItemQuery : IRequest<ItemDTO>
    {
        public Guid Id { get; set; }
    }
}
