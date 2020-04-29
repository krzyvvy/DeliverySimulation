using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Models.Entity
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string CountryCode { get; set; }

    }
}
