using Domain.Entities;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IItemRepository : IRepositoryBase<Item>
    {
        Task PushAsync(Item item, int amount);

        Task PopAsync(Item item, int amount);
    }
}