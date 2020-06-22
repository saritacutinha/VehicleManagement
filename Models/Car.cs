using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagement.Models
{
    public class Car : Vehicle
    {
        public string  Engine { get; set; }
        public int Door { get; set; }
        public int Wheel { get; set; }

    }
}
