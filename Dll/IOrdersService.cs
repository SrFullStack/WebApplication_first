using Entitiy;

namespace Service
{
    public interface IOrdersService
    {
        Task<Order> Post(Order order);
    }
}