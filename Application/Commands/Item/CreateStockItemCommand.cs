using System;
using MediatR;

namespace Application.Commands.Item
{
    public class CreateStockItemCommand : IRequest
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
