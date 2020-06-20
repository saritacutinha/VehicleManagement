using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagement.Persistence
{
    public class VehicleManagementDbContext : DbContext
    {
        public VehicleManagementDbContext(DbContextOptions<VehicleManagementDbContext> options) 
            : base(options)
        {

        }
    }
}
