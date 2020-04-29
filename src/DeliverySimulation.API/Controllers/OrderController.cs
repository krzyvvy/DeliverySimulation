using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliverySimulation.Models.Information;
using DeliverySimulation.Service.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySimulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderInformation orderInformation)
        {
            await _service.AddOrder(orderInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var result = await _service.GetOrders();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var result = await _service.GetOrder(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditOrder(OrderInformation orderInformation)
        {
            await _service.EditOrder(orderInformation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _service.DeleteOrder(id);
            return Ok();
        }
    }
}