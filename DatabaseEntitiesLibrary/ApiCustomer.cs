using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntitiesLibrary
{
    public class ApiCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Customer First Name Required")]
        [MinLength(1, ErrorMessage = "Customer Name Minimum Length 1")]
        [MaxLength(35, ErrorMessage = "Customer Name Maximum Length 35")]
        public string CustomerFname { get; set; }
        [Required(ErrorMessage = "Customer Last Name Required")]
        [MinLength(1, ErrorMessage = "Customer Last Name Minimum Length 1")]
        [MaxLength(35, ErrorMessage = "Customer Last Name Maximum Length 35")]
        public string CustomerLname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCivicNo { get; set; }
        public string CustomerStreetName { get; set; }
        public string CustomerAppartment { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerProvince { get; set; }
        public string CustomerPostalCode { get; set; }
        public Nullable<bool> CustomerIsActive { get; set; }
    }
}
