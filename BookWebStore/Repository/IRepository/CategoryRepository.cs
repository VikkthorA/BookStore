using BookStore.DataAcess.Data;
using BookStore.Models;

namespace BookWebStore.Repository.IRepository
{
    public class CategoryRepository : Repository<Category>, IRepositoryCategory
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
