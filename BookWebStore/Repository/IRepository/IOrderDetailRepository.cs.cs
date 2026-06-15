using BookStore.Models;
using Models.BookWebStore;

namespace BookWebStore.Repository.IRepository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail orderDetail);
    }
}
