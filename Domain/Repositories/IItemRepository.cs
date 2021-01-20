using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IItemRepository : IRepositoryBase<Item>
    {
        Task PushAsync(Item item, int amount);
        Task PopAsync(Item item, int amount);
    }
}
