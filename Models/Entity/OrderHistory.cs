using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Models.Entity
{
    public class OrderHistory
    {
        [Key]
        public int OrderHistoryId { get; set; }
        public DateTime WorkerDeparture { get; set; }
        public DateTime WorkerArrival { get; set; }
        public int OrderId { get; set; }
        public int WorkerId { get; set; }
    }
}
