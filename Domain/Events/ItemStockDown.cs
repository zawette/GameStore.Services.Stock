using Domain.Entities;

namespace Domain.Events
{
    public class ItemStockDown : IDomainEvent
    {
        public Item item { get; set; }

        public ItemStockDown(Item item)
        {
            this.item = item;
        }
    }
}