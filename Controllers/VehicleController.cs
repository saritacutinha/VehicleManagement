using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Controllers.Resources;
using VehicleManagement.Core;
using VehicleManagement.Models;
using VehicleManagement.Persistence;

namespace VehicleManagement.Controllers
{
    [Route("/api/vehicles")]
    public class VehicleController : Controller
    {
        private readonly IMapper mapper;       
        private readonly IVehicleRepository<Car> repository;
        private readonly IUnitOfWork unitOfWork;

        public VehicleController(IMapper mapper, IVehicleRepository<Car> repository, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;            
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] SaveCarResource vehicleResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
           
            var vehicle = mapper.Map<SaveCarResource, Car>(vehicleResource);
            vehicle.LastUpdate = DateTime.Now;
            repository.AddVehicle(vehicle);
            await unitOfWork.CompleteAsync();

            vehicle = await repository.GetVehicle(vehicle.Id);
            var result = mapper.Map<Vehicle, CarResource>(vehicle);
            return Ok(result);            
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult>GetVehicles(int id)
        {
            var car = await repository.GetVehicle(id);
            if (car == null)
                return NotFound();
            var carResource = mapper.Map<Vehicle, CarResource>(car);
            return Ok(carResource);
        }      

        }

    }

