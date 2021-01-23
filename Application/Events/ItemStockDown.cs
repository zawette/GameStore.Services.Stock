using System;

namespace Application.Events
{
    public class ItemStockDown : IEvent
    {
        public ItemStockDown(Guid id, int amount)
        {
            Id = id;
            Amount = amount;
        }

        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
