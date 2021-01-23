using System.Collections.Generic;
using System.Linq;
using Application.Events;
using Application.Services;
using Domain.Events;
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
                ItemCreated e => new ItemAdded(e.item.Id),
                ItemDeleted e => new ItemRemoved(e.item.Id),
                ItemStockDown e => new Application.Events.ItemStockDown(e.item.Id,e.item.Amount), 
                ItemStockUp e => new Application.Events.ItemStockUp(e.item.Id,e.item.Amount), 
                ItemStockEmpty e => new Application.Events.ItemStockEmpty(e.item.Id), 
                _ => null
            };

        public IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events)
            => events.Select(Map);
    }
}