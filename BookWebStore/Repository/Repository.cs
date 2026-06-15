using BookStore.DataAcess.Data;
using BookWebStore.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace BookWebStore.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>(); //  ==> dbSet == _db.Categories
            _db.Products.Include(u => u.Category).Include(u => u.CategoryId);
        }
        public void Add(T entity) 
        {
            dbSet.Add(entity); // ==> _db.Categories.Add(category);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity); // ==> _db.Categories.Remove(category);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity); // ==> _db.Categories.RemoveRange(categories);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false)
        {
            IQueryable<T> query; 
            if(tracked)
            {
                query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) //Category, CoverType -> we split it bcz we want to include multiple properties and they are separated by comma
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if(filter != null) { query = query.Where(filter); }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) //Category, CoverType -> we split it bcz we want to include multiple properties and they are separated by comma
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.ToList();
        }
    }
}
