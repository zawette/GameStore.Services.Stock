using System;

namespace Application.Events
{
    public class StockItemStockUp : IEvent
    {
        public StockItemStockUp(Guid id, int amount)
        {
            Id = id;
            Amount = amount;
        }

        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}