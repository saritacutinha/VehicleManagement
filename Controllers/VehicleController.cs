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
    [Route("/api/vehicles")]
    public class VehicleController : Controller
    {
        private readonly IMapper mapper;
        private readonly VehicleManagementDbContext context;

        public VehicleController(IMapper mapper, VehicleManagementDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] SaveCarResource vehicleResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var model = await context.Models.FindAsync(vehicleResource.ModelId);
            if (model == null)
            {
                ModelState.AddModelError("ModelId", "Invalid Model Id");
                return BadRequest(ModelState);
            }

            var vehicle = mapper.Map<SaveCarResource, Car>(vehicleResource);
            vehicle.LastUpdate = DateTime.Now;
            context.Cars.Add(vehicle);
            await context.SaveChangesAsync();
            var result = mapper.Map<Car, SaveCarResource>(vehicle);
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult>GetVehicles(int id)
        {
            
            var vehicle = await context.Vehicles
                            .Include(v => v.Type)
                            .Include(v => v.Model)
                           .ThenInclude(v => v.Make)
                            .SingleOrDefaultAsync(v=>v.Id == id);

            if (vehicle == null)
                return NotFound();
            var vehicleResource = mapper.Map<Vehicle, CarResource>(vehicle);
            return Ok(vehicleResource);
        }      

        }

    }

