using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Models.Entity
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public enum Status { Nadanie_przesylki, Wyslanie_przesylki, Doreczenie}
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
