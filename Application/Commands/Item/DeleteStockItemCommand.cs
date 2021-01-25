using System;
using MediatR;

namespace Application.Commands.Item
{
    public class DeleteStockItemCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
