using MediatR;
using System;

namespace Application.Commands.Item
{
    public class StockItemStockDownCommand : IRequest
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}