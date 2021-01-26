using Domain.Events;
using Domain.Exceptions;
using System;

namespace Domain.Entities
{
    public class Item : AggregateRoot
    {
        public int Amount { get; set; }

        public Item(Guid Id, int version = 0, int amount = 0)
        {
            this.Id = Id;
            this.Version = version;
            Amount = amount;
        }

        public static Item Create(Guid Id, int amount)
        {
            var item = new Item(Id, amount: amount);
            item.AddEvent(new ItemCreated(item));
            return item;
        }

        public static Item Push(Item item, int amount)
        {
            item.Amount += amount;
            item.AddEvent(new ItemStockUp(item));
            return item;
        }

        public static Item Pop(Item item, int amount)
        {
            if (amount > item.Amount)
            {
                throw new NotEnoughStockException(item.Id);
            }
            else
            {
                item.Amount -= amount;
                item.AddEvent(new ItemStockDown(item));
                if (item.Amount == 0)
                {
                    item.AddEvent(new ItemStockEmpty(item));
                }
                return item;
            }
        }

        public void Delete(Item item)
        {
            item.AddEvent(new ItemDeleted(item));
        }
    }
}