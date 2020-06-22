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
    public class MakesController : Controller
    {
        private readonly VehicleManagementDbContext context;
        private readonly IMapper mapper;
        public MakesController(VehicleManagementDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
           var makes =  await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
