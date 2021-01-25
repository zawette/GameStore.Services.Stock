using System;

namespace Application.Events
{
    public class StockItemAdded : IEvent
    {
        public Guid Id { get; set; }

        public StockItemAdded(Guid id)
        {
            Id = id;
        }
    }
}