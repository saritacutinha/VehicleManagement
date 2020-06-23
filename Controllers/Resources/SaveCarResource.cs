using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Migrations;

namespace VehicleManagement.Controllers.Resources
{
    public class SaveCarResource :SaveVehicleResource
    {
        public string Engine { get; set; }
        public int Door { get; set; }
        public int Wheel { get; set; }
    }
}
