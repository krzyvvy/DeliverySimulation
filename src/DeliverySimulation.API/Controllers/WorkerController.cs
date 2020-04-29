using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliverySimulation.Models.Information;
using DeliverySimulation.Service.Worker;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySimulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _service;

        public WorkerController(IWorkerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddWorker(WorkerInformation workerInformation)
        {
            await _service.AddWorker(workerInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkers()
        {
            var result = await _service.GetWorkers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorker(int id)
        {
            var result = await _service.GetWorker(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditWorker(WorkerInformation workerInformation)
        {
            await _service.EditWorker(workerInformation);
            return Ok();
        }
    }
}