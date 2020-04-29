using AutoMapper;
using DeliverySimulation.Data;
using DeliverySimulation.Models.Entity;
using DeliverySimulation.Models.Information;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Repository.Clients
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ClientRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddClient(ClientInformation clientInformation)
        {
            var client = _mapper.Map<Client>(clientInformation);
            await _context.Clients.AddAsync(client);

            await _context.SaveChangesAsync();
        }

        public async Task EditClient(ClientInformation clientInformation)
        {
            var client = _mapper.Map<Client>(clientInformation);
            _context.Clients.Update(client);

            await _context.SaveChangesAsync();
        }

        public async Task<ClientInformation> GetClient(int id)
        {
            var client = await _context.Clients.SingleOrDefaultAsync(x => x.ClientId == id);
            return _mapper.Map<ClientInformation>(client);
        }

        public async Task<IEnumerable<ClientInformation>> GetClients()
        {
            var clients = await _context.Clients.ToListAsync();
            return _mapper.Map<IEnumerable<ClientInformation>>(clients);
        }
    }
}
