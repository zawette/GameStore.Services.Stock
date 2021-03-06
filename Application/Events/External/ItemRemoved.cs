using MediatR;
using System;

namespace Application.Events
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