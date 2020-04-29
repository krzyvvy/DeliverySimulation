using DeliverySimulation.Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static DeliverySimulation.Models.Information.OrderInformation;

namespace DeliverySimulation.Models.Entity
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public StatusDelivery Status { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Weight { get; set; }
        public string Content { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
