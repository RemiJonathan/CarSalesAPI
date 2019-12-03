using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEntitiesLibrary
{
    public class ApiVehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required(ErrorMessage = "Vehicule Model Name Required")]
        [MinLength(1, ErrorMessage = "Vehicule Model Minimum Length 1")]
        [MaxLength(10, ErrorMessage = "Vehicule Model Maximum Length 10")]
        public string VehicleModel { get; set; }
        [Required(ErrorMessage = "Vehicule Year  Required")]
        [MinLength(4, ErrorMessage = "Vehicule Year Minimum Length 4")]
        [MaxLength(4, ErrorMessage = "Vehicule Year Maximum Length 4")]
        public string VehicleYear { get; set; }
        [Required(ErrorMessage = "Vehicule Manufacturer Required")]
        [MinLength(1, ErrorMessage = "Vehicule Manufacturer Minimum Length 1")]
        [MaxLength(20, ErrorMessage = "Vehicule Manufacturer Maximum Length 20")]
        public string VehicleManufacturer { get; set; }
        [Required(ErrorMessage = "Vehicule Description Required")]
        [MinLength(1, ErrorMessage = "Vehicule Description Minimum Length 1")]
        [MaxLength(100, ErrorMessage = "Vehicule Description Maximum Length 100")]
        public string VehicleDescription { get; set; }
        [Required(ErrorMessage = "Vehicule Price Required")]
        [Range (1,1000000000,ErrorMessage ="Vehicule Price Range must be between 1 and 1 000 000 000")]
        public Nullable<decimal> VehiclePrice { get; set; }
        [Required(ErrorMessage = "Commission Required")]
        [Range(1, 1000, ErrorMessage = "Commission Range must be between 1 and 1000")]
        public Nullable<decimal> Commission { get; set; }
        [Required(ErrorMessage = "Stock Required")]
        public Nullable<int> Stock { get; set; }
        public Nullable<bool> VehicleIsActive { get; set; }
    }
}
