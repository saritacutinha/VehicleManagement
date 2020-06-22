using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Controllers.Resources;
using VehicleManagement.Models;
using VehicleManagement.Persistence;

namespace VehicleManagement.Controllers
{
    public class VehicleTypesController : Controller
    {
        private readonly VehicleManagementDbContext context;
        private readonly IMapper mapper;
        public VehicleTypesController(VehicleManagementDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("api/vehicleTypes")]
        public async Task<IEnumerable<VehicleTypeResource>> GetVehicleTypes()
        {
            var vehicleTypes = await context.VehicleTypes.ToListAsync();
            return mapper.Map<List<VehicleType>, List<VehicleTypeResource>>(vehicleTypes);
        }
    }
}
