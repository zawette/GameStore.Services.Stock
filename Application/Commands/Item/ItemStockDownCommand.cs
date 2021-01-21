using System;
using MediatR;

namespace Application.Commands.Item
{
    public class ItemStockDownCommand : IRequest
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
