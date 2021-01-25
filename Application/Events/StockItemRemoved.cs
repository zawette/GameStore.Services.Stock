using System;

namespace Application.Events
{
    public class StockItemRemoved : IEvent
    {
        public Guid Id { get; set; }

        public StockItemRemoved(Guid id)
        {
            Id = id;
        }
    }
}