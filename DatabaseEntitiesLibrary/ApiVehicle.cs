using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntitiesLibrary
{
    public class ApiVehicle
    {
        public int VehicleId { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleYear { get; set; }
        public string VehicleManufacturer { get; set; }
        public string VehicleDescription { get; set; }
        public double VehiclePrice { get; set; }
        public double Commission { get; set; }
        public int Stock { get; set; }
        public bool Active { get; set; }
    }
}
