using DeliverySimulation.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Service.Client
{
     public interface IClientService
    {
        Task AddClient(ClientInformation clientInformation);
        Task<ClientInformation> GetClient(int id);
        Task<IEnumerable<ClientInformation>> GetClients();
        Task EditClient(ClientInformation clientInformation);
    }
}
