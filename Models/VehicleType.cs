using System;
using System.Collections.Generic;
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
    }
}
