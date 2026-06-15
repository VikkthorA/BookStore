using BookStore.Models;
using Models.BookWebStore;

namespace BookWebStore.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
