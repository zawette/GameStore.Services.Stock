using System;

namespace Application.Events
{
    public class StockItemStockEmpty : IEvent
    {
        public Guid Id { get; set; }

        public StockItemStockEmpty(Guid id)
        {
            Id = id;
        }
    }
}