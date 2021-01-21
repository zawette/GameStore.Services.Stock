using System;
using MediatR;

namespace Application.Commands.Item
{
    public class DeleteItemCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
