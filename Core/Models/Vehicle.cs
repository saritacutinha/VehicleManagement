using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagement.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int  ModelId { get; set; }
        public Model Model { get; set; }
       
        public VehicleType Type { get; set; }
        public short VehicleTypeId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
