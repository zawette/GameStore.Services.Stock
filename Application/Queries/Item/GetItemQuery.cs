using Application.DTO;
using MediatR;
using System;

namespace Application.Queries.Item
{
    public class GetItemQuery : IRequest<ItemDTO>
    {
        public Guid Id { get; set; }
    }
}