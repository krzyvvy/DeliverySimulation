using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliverySimulation.Models.Information;
using DeliverySimulation.Service.OrderHistory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySimulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderHistoryController : ControllerBase
    {
        private readonly IOrderHistoryService _service;

        public OrderHistoryController(IOrderHistoryService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrderHistory(OrderHistoryInformation orderHistoryInformation)
        {
            await _service.AddOrderHistory(orderHistoryInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderHistories()
        {
            var result = await _service.GetOrderHistories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderHistory(int id)
        {
            var result = await _service.GetOrderHistory(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditOrderHistory(OrderHistoryInformation orderHistoryInformation)
        {
            await _service.EditOrderHistory(orderHistoryInformation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderHistory(int id)
        {
            await _service.DeleteOrderHistory(id);
            return Ok();
        }
    }
}