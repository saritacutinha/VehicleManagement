using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Models;

namespace VehicleManagement.Persistence
{
    public class VehicleRepository
    {
        private readonly VehicleManagementDbContext context;

        public VehicleRepository(VehicleManagementDbContext context)
        {
            this.context = context;
        }
        public async Task<Vehicle>GetVehicle(int id)=>
        
            await context.Vehicles
                           .Include(v => v.Type)
                           .Include(v => v.Model)
                          .ThenInclude(v => v.Make)
                           .SingleOrDefaultAsync(v => v.Id == id);

        
    }
}
