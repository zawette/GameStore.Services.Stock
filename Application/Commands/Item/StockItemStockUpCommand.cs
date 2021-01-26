using MediatR;
using System;

namespace Application.Commands.Item
{
    public class StockItemStockUpCommand : IRequest
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}