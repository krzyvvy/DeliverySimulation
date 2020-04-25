using DeliverySimulation.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Repository.Orders
{
    public interface IOrderRepository
    {
        Task AddOrder(OrderInformation orderInformation);
        Task<OrderInformation> GetOrder(int id);
        Task<IEnumerable<OrderInformation>> GetOrders();
        Task EditOrder(OrderInformation orderInformation);
        Task DeleteOrder(int id);
    }
}
