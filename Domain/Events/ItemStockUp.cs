using Domain.Entities;

namespace Domain.Events
{
    public class ItemStockUp : IDomainEvent
    {
        public Item item { get; set; }

        public ItemStockUp(Item item)
        {
            this.item = item;
        }
    }
}