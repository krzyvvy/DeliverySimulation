using DeliverySimulation.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Repository.OrderHistories
{
    public interface IOrderHistoryRepository
    {
        Task AddOrderHistory(OrderHistoryInformation orderHistoryInformation);
        Task<OrderHistoryInformation> GetOrderHistory(int id);
        Task<IEnumerable<OrderHistoryInformation>> GetOrderHistories();
        Task EditOrderHistory(OrderHistoryInformation orderHistoryInformation);
        Task DeleteOrderHistory(int id);
    }
}
