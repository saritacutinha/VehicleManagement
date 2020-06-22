using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagement.Models
{
    public class VehicleType
    {
        public short Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
        public VehicleType()
        {
            Vehicles = new Collection<Vehicle>();
        }
    }
}
