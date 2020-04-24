using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Models.Entity
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        public string Full_name { get; set; }
        public string Adress { get; set; }
        public string Country_code { get; set; }

    }
}
