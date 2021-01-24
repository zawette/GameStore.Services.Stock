using System;
using MediatR;

namespace Application.Events.External
{
    public class ItemAdded : IEvent, IRequest
    {
        public Guid Id { get; set; }

        public ItemAdded(Guid id)
        {
            Id = id;
        }
    }
}