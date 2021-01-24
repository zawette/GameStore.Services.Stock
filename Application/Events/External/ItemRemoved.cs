using System;
using MediatR;

namespace Application.Events.External
{
    public class ItemRemoved : IEvent, IRequest
    {
        public Guid Id { get; set; }

        public ItemRemoved(Guid id)
        {
            Id = id;
        }
    }
}