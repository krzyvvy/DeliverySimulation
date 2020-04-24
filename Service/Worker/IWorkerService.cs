using DeliverySimulation.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Service.Worker
{
    public interface IWorkerService
    {
        Task AddWorker(WorkerInformation workerInformation);
        Task<WorkerInformation> GetWorker(int id);
        Task<IEnumerable<WorkerInformation>> GetWorkers();
        Task EditWorker(WorkerInformation workerInformation);
    }
}
