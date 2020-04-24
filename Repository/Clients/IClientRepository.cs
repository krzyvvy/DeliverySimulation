using DeliverySimulation.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Repository.Clients
{
    public interface IClientRepository
    {
        Task AddClient(ClientInformation clientInformation);
        Task<ClientInformation> GetClient(int id);
        Task<IEnumerable<ClientInformation>> GetClients();
        Task EditClient(ClientInformation clientInformation);
    }
}
