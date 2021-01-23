using System;

namespace Application.Events
{
    public class ItemStockUp : IEvent
    {
        public ItemStockUp(Guid id, int amount)
        {
            Id = id;
            Amount = amount;
        }

        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
