using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagement.Controllers.Resources
{
    public class CarResource : VehicleResource
    {
        public string Engine { get; set; }
        public int Door { get; set; }
        public int Wheel { get; set; }
    }
}
