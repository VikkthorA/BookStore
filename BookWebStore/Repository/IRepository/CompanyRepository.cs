using BookStore.DataAcess.Data;
using BookStore.Models;
using Models.BookWebStore;

namespace BookWebStore.Repository.IRepository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Companies.Update(company);
        }
    }
}
