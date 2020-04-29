using DeliverySimulation.Models.Information;
using DeliverySimulation.Repository.OrderHistories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Service.OrderHistory
{
    public class OrderHistoryService : IOrderHistoryService
    {
        private readonly IOrderHistoryRepository _repository;

        public OrderHistoryService(IOrderHistoryRepository repository)
        {
            _repository = repository;
        }

        public async Task AddOrderHistory(OrderHistoryInformation orderHistoryInformation)
        {
            await _repository.AddOrderHistory(orderHistoryInformation);
        }

        public async Task DeleteOrderHistory(int id)
        {
            await _repository.DeleteOrderHistory(id);
        }

        public async Task EditOrderHistory(OrderHistoryInformation orderHistoryInformation)
        {
            await _repository.EditOrderHistory(orderHistoryInformation);
        }

        public async Task<IEnumerable<OrderHistoryInformation>> GetOrderHistories()
        {
            return await _repository.GetOrderHistories();
        }

        public async Task<OrderHistoryInformation> GetOrderHistory(int id)
        {
            return await _repository.GetOrderHistory(id);
        }
    }
}
