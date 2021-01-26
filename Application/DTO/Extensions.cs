using Domain.Entities;

namespace Application.DTO
{
    public static class Extensions
    {
        public static ItemDTO asItemDTO(this Item item)
        => new ItemDTO() { Id = item.Id, Amount = item.Amount };
    }
}