using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Controllers.Resources;
using VehicleManagement.Models;

namespace VehicleManagement.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<VehicleType, VehicleTypeResource>();
            CreateMap<Vehicle, VehicleResource>();
            CreateMap<Car, CarResource>();
            //Api resource to Domain
            CreateMap<SaveVehicleResource, Vehicle>();
            CreateMap<SaveCarResource, Car>();

        }
    }
}
