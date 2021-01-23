using System;

namespace Application.Events
{
    public class ItemStockEmpty : IEvent
    {
        public Guid Id { get; set; }

        public ItemStockEmpty(Guid id)
        {
            Id = id;
        }
    }
}