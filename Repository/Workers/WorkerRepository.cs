using AutoMapper;
using DeliverySimulation.Data;
using DeliverySimulation.Models.Entity;
using DeliverySimulation.Models.Information;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Repository.Workers
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public WorkerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddWorker(WorkerInformation workerInformation)
        {
            var worker = _mapper.Map<Worker>(workerInformation);
            await _context.AddAsync(worker);

            await _context.SaveChangesAsync();
        }

        public async Task EditWorker(WorkerInformation workerInformation)
        {
            var worker = _mapper.Map<Worker>(workerInformation);
            _context.Update(worker);

            await _context.SaveChangesAsync();
        }

        public async Task<WorkerInformation> GetWorker(int id)
        {
            var worker = await _context.Workers.FirstOrDefaultAsync(x => x.WorkerId == id);
            return _mapper.Map<WorkerInformation>(worker);
        }

        public async Task<IEnumerable<WorkerInformation>> GetWorkers()
        {
            var workers = await _context.Workers.ToListAsync();
            return _mapper.Map<IEnumerable<WorkerInformation>>(workers);
        }
    }
}
