using System;

namespace Application.Events
{
    public class StockItemStockDown : IEvent
    {
        public StockItemStockDown(Guid id, int amount)
        {
            Id = id;
            Amount = amount;
        }

        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}