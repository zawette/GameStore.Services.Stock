using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using Domain.Entities;

namespace Application.DTO
{
    public static class Extensions
    {
        public static ItemDTO asItemDTO(Item item)
        => new ItemDTO(){Id=item.Id, Amount=item.Amount};
    }
}
