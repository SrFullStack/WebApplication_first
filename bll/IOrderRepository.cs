using Entitiy;

namespace T_Repository
{
    public interface IOrderRepository
    {
        //Task<Order> Post(Order order);
        Task AddOrder(Order order);
    }
}