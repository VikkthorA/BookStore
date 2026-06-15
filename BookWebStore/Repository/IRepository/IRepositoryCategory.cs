using BookStore.Models;

namespace BookWebStore.Repository.IRepository
{
    public interface IRepositoryCategory : IRepository<Category>
    {
        void Update(Category category);
    }
}
