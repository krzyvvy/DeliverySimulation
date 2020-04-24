using AutoMapper;
using DeliverySimulation.Models.Entity;
using DeliverySimulation.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulation.Helpper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Client, ClientInformation>().ReverseMap();
            CreateMap<Order, OrderInformation>().ReverseMap();
            CreateMap<OrderHistory, OrderHistoryInformation>().ReverseMap();
            CreateMap<Worker, WorkerInformation>().ReverseMap();
        }

    }
}
