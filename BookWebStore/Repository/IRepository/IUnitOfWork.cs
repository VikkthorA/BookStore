namespace BookWebStore.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRepositoryCategory Category { get; }
        IProductRepository Product { get; } 
        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IOrderDetailRepository OrderDetail { get; }
        IOrderHeaderRepository OrderHeader { get; }
        void Save();
    }
}
