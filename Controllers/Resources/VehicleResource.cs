using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Models;

namespace VehicleManagement.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
       
        public ModelResource Model { get; set; }
        public MakeResource Make { get; set; }
        public VehicleType Type { get; set; }
       
        public DateTime LastUpdate { get; set; }
    }
}
