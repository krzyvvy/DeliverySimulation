using DeliverySimulation.Models.Information;
using DeliverySimulation.Repository.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Service.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task AddOrder(OrderInformation orderInformation)
        {
            await _repository.AddOrder(orderInformation);
        }

        public async Task DeleteOrder(int id)
        {
            await _repository.DeleteOrder(id);
        }

        public async Task EditOrder(OrderInformation orderInformation)
        {
            await _repository.EditOrder(orderInformation);
        }

        public async Task<OrderInformation> GetOrder(int id)
        {
            return await _repository.GetOrder(id);
        }

        public async Task<IEnumerable<OrderInformation>> GetOrders()
        {
            return await _repository.GetOrders();
        }
    }
}
