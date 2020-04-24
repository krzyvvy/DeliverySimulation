using DeliverySimulation.Models.Information;
using DeliverySimulation.Repository.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Service.Worker
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository _repository;

        public WorkerService(IWorkerRepository repository)
        {
            _repository = repository;
        }
        public async Task AddWorker(WorkerInformation workerInformation)
        {
            await _repository.AddWorker(workerInformation);
        }

        public async Task EditWorker(WorkerInformation workerInformation)
        {
            await _repository.EditWorker(workerInformation);
        }

        public async Task<WorkerInformation> GetWorker(int id)
        {
            return await _repository.GetWorker(id);
        }

        public async Task<IEnumerable<WorkerInformation>> GetWorkers()
        {
            return await _repository.GetWorkers();
        }
    }
}
