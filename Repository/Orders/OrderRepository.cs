using AutoMapper;
using DeliverySimulation.Data;
using DeliverySimulation.Models.Entity;
using DeliverySimulation.Models.Information;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Repository.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public OrderRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddOrder(OrderInformation orderInformation)
        {
            var order = _mapper.Map<Order>(orderInformation);
            await _context.AddAsync(order);

            await _context.SaveChangesAsync();
        }

        public async  Task DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Remove(order);
            await _context.SaveChangesAsync();
        }

        public async Task EditOrder(OrderInformation orderInformation)
        {
            var order = _mapper.Map<Order>(orderInformation);
            _context.Update(order);

            await _context.SaveChangesAsync();
        }

        public async Task<OrderInformation> GetOrder(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.OrderId == id);
            return _mapper.Map<OrderInformation>(order);
        }

        public async Task<IEnumerable<OrderInformation>> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return _mapper.Map<IEnumerable<OrderInformation>>(orders);
        }
    }
}
