using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Models.Information
{
    public class OrderHistoryInformation
    {
        public int? OrderHistoryId { get; set; }
        public DateTime WorkerDeparture { get; set; }
        public DateTime WorkerArrival { get; set; }
        public int OrderId { get; set; }
        public int WorkerId { get; set; }
    }
}
