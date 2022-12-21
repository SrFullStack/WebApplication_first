using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Repository;
using Entitiy;

namespace Service
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrderRepository _IOrderRepository;
        public OrdersService(IOrderRepository IOrderRepository)
        {
            _IOrderRepository = IOrderRepository;
        }
        async public Task<Order> Post(Order order)
        {

            Order resorder = await _IOrderRepository.Post(order);
            if (resorder != null)
                return resorder;
            return null;

        }


    }
}
