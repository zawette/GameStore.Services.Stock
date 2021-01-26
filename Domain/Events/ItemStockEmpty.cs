using Domain.Entities;

namespace Domain.Events
{
    public class ItemStockEmpty : IDomainEvent
    {
        public Item item { get; set; }

        public ItemStockEmpty(Item item)
        {
            this.item = item;
        }
    }
}