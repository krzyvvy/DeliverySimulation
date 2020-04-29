using DeliverySimulation.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Service.OrderHistory
{
    public interface IOrderHistoryService
    {
        Task AddOrderHistory(OrderHistoryInformation orderHistoryInformation);
        Task<OrderHistoryInformation> GetOrderHistory(int id);
        Task<IEnumerable<OrderHistoryInformation>> GetOrderHistories();
        Task EditOrderHistory(OrderHistoryInformation orderHistoryInformation);
        Task DeleteOrderHistory(int id);
    }
}
