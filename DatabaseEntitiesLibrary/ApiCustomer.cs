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
        [Required(ErrorMessage = "Customer Email Required")]
        [EmailAddress]
        [MaxLength(75, ErrorMessage = "Customer Email Maximum Length 75")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Customer Phone Number Required")]
        [MinLength(1, ErrorMessage = "Customer Phone Minimum Length 1")]
        [MaxLength(30, ErrorMessage = "Customer Phone Maximum Length 30")]
        public string CustomerPhone { get; set; }
        [Required(ErrorMessage = "Customer Civiv No. Required")]
        [MinLength(1, ErrorMessage = "Customer Civic No. Minimum Length 1")]
        [MaxLength(10, ErrorMessage = "Customer Civic No. Maximum Length 10")]
        public string CustomerCivicNo { get; set; }
        [Required(ErrorMessage = "Customer Street Name Required")]
        [MinLength(1, ErrorMessage = "Customer Street Name Minimum Length 1")]
        [MaxLength(20, ErrorMessage = "Customer Street Name Maximum Length 20")]
        public string CustomerStreetName { get; set; }
        public string CustomerAppartment { get; set; }
        [Required(ErrorMessage = "Customer City Required")]
        [MinLength(1, ErrorMessage = "Customer City Minimum Length 1")]
        [MaxLength(30, ErrorMessage = "Customer City Maximum Length 30")]
        public string CustomerCity { get; set; }
        [Required(ErrorMessage = "Customer Province Required")]
        [MinLength(2, ErrorMessage = "Customer Province Minimum Length 2")]
        [MaxLength(2, ErrorMessage = "Customer Province Maximum Length 2")]
        public string CustomerProvince { get; set; }
        [Required(ErrorMessage = "Customer Postal Code Required")]
        [MinLength(1, ErrorMessage = "Customer Postal Code Minimum Length 1")]
        [MaxLength(6, ErrorMessage = "Customer Postal Code Maximum Length 6")]
        public string CustomerPostalCode { get; set; }
        public Nullable<bool> CustomerIsActive { get; set; }
    }
}
