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
            CreateMap<Make, KeyValuePairResource>();
            CreateMap<Model, KeyValuePairResource>();
            CreateMap<VehicleType, KeyValuePairResource>();
            CreateMap<Vehicle, VehicleResource>()
                .ForMember(vr => vr.Make, opt => opt.MapFrom(v => v.Model.Make));                            
            CreateMap<Car, CarResource>()
                .ForMember(vr => vr.Make, opt => opt.MapFrom(v => v.Model.Make)); 
            CreateMap<Vehicle, SaveVehicleResource>();
            CreateMap<Car, SaveCarResource>();

            //Api resource to Domain
            CreateMap<SaveVehicleResource, Vehicle>();
            CreateMap<SaveCarResource, Car>();

        }
    }
}
