using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliverySimulation.Models.Information;
using DeliverySimulation.Service.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySimulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddClient(ClientInformation clientInformation)
        {
            await _service.AddClient(clientInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var result = await _service.GetClients();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var result = await _service.GetClient(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditClient(ClientInformation clientInformation)
        {
            await _service.EditClient(clientInformation);
            return Ok();
        }
    }
}