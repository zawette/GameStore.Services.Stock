using MediatR;
using System;

namespace Application.Commands.Item
{
    public class DeleteStockItemCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}