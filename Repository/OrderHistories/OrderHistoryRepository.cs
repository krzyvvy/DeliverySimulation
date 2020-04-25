using AutoMapper;
using DeliverySimulation.Data;
using DeliverySimulation.Models.Entity;
using DeliverySimulation.Models.Information;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Repository.OrderHistories
{
    public class OrderHistoryRepository : IOrderHistoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public OrderHistoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddOrderHistory(OrderHistoryInformation orderHistoryInformation)
        {
            var orderhistory = _mapper.Map<OrderHistory>(orderHistoryInformation);
            await _context.AddAsync(orderhistory);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderHistory(int id)
        {
            var orderhistory = await _context.OrderHistories.FindAsync(id);
            _context.Remove(orderhistory);

            await _context.SaveChangesAsync();
        }

        public async Task EditOrderHistory(OrderHistoryInformation orderHistoryInformation)
        {
            var orderhistory = _mapper.Map<OrderHistory>(orderHistoryInformation);
            _context.Update(orderhistory);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderHistoryInformation>> GetOrderHistories()
        {
            var orderhistories = await _context.OrderHistories.ToListAsync();
            return _mapper.Map<IEnumerable<OrderHistoryInformation>>(orderhistories);
        }

        public async Task<OrderHistoryInformation> GetOrderHistory(int id)
        {
            var orderhistory = await _context.OrderHistories.FirstOrDefaultAsync(x => x.OrderHistoryId == id);
            return _mapper.Map<OrderHistoryInformation>(orderhistory);

        }
    }
}
