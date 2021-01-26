using Application.Events;
using Application.Services;
using Domain.Events;
using System.Collections.Generic;
using System.Linq;
using ItemStockDown = Domain.Events.ItemStockDown;
using ItemStockEmpty = Domain.Events.ItemStockEmpty;
using ItemStockUp = Domain.Events.ItemStockUp;

namespace Infrastructure.Services
{
    public class EventMapper : IEventMapper
    {
        public IEvent Map(IDomainEvent @event)
            => @event switch
            {
                ItemCreated e => new StockItemAdded(e.item.Id),
                ItemDeleted e => new StockItemRemoved(e.item.Id),
                ItemStockDown e => new Application.Events.StockItemStockDown(e.item.Id, e.item.Amount),
                ItemStockUp e => new Application.Events.StockItemStockUp(e.item.Id, e.item.Amount),
                ItemStockEmpty e => new Application.Events.StockItemStockEmpty(e.item.Id),
                _ => null
            };

        public IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events)
            => events.Select(Map);
    }
}