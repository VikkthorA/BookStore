using BookStore.Models;
using Models.BookWebStore;

namespace BookWebStore.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart shoppingCart);
    }
}
