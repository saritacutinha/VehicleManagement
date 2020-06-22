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
            //Api resource to Domain
            CreateMap<VehicleResource, Vehicle>();
            CreateMap<CarResource, Car>();
        }
    }
}
