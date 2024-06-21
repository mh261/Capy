using Capy.Models;
using Capy.Models.Dtos;

namespace Capy.Repositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int CapyId, int qty);
        Task<int> RemoveItem(int CapyId);
        Task<ShoppingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingCart> GetCart(string userId);
        Task<bool> DoCheckout(CheckOut model);
    }
}
