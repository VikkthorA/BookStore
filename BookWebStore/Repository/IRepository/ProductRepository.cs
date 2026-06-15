using BookStore.DataAcess.Data;
using BookStore.Models;
using Models.BookWebStore;

namespace BookWebStore.Repository.IRepository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == product.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = product.Title;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.Description = product.Description;
                objFromDb.Author = product.Author;
                objFromDb.CategoryId = product.CategoryId;
                if(product.ImgUrl != null) {
                     objFromDb.ImgUrl = product.ImgUrl;
                     }
            }
        }
    }
}
