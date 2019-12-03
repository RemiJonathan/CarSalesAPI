using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEntitiesLibrary
{
    public class ApiSale
    {
        [Key]
        public int SaleId { get; set; }
        [Required(ErrorMessage = "CustomerId Required")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Salesperon Id Required")]
        public int SalespersonId { get; set; }
        [Required(ErrorMessage = "Vehicule Id Required")]
        public int VehicleId { get; set; }
    }
}
