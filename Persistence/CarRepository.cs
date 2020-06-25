using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Core;
using VehicleManagement.Models;

namespace VehicleManagement.Persistence
{
    public class CarRepository : IVehicleRepository<Car>
    {
        private readonly VehicleManagementDbContext context;

        public CarRepository(VehicleManagementDbContext context)
        {
            this.context = context;
        }
        public async Task<Car>GetVehicle(int id)
        {
            return  await context.Cars
                           .Include(v => v.Type)
                           .Include(v => v.Model)
                          .ThenInclude(v => v.Make)
                           .SingleOrDefaultAsync(v => v.Id == id);           


        }

        public void AddVehicle(Car car)
        {
            context.Cars.Add(car);
        }

    }
}
