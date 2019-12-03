using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntitiesLibrary
{
    public class ApiSalesperson
    {
        [Key]
        public int SalespersonId { get; set; }
        [Required(ErrorMessage = "Salesperson First Name Required")]
        [MinLength(1, ErrorMessage = "Salesperson Name Minimum Length 1")]
        [MaxLength(35, ErrorMessage = "Salesperson Name Maximum Length 35")]
        public string SalespersonFname { get; set; }
        [Required(ErrorMessage = "Salesperson Last Name Required")]
        [MinLength(1, ErrorMessage = "Salesperson Last Name Minimum Length 1")]
        [MaxLength(35, ErrorMessage = "Salesperson Last Name Maximum Length 35")]
        public string SalespersonLname { get; set; }
        [Required(ErrorMessage = "Salesperson Email Required")]
        [EmailAddress]
        [MaxLength(75, ErrorMessage = "Salesperson Email Maximum Length 75")]
        public string SalespersonEmail { get; set; }
        [Required(ErrorMessage = "Salesperson Phone Number Required")]
        [MinLength(1, ErrorMessage = "Salesperson Phone Minimum Length 1")]
        [MaxLength(30, ErrorMessage = "Salesperson Phone Maximum Length 30")]
        public string SalespersonPhone { get; set; }
        [Required(ErrorMessage = "Salesperson Civiv No. Required")]
        [MinLength(1, ErrorMessage = "Salesperson Civic No. Minimum Length 1")]
        [MaxLength(10, ErrorMessage = "Salesperson Civic No. Maximum Length 10")]
        public string SalespersonCivicNo { get; set; }
        [Required(ErrorMessage = "Salesperson Street Name Required")]
        [MinLength(1, ErrorMessage = "Salesperson Street Name Minimum Length 1")]
        [MaxLength(20, ErrorMessage = "Salesperson Street Name Maximum Length 20")]
        public string SalespersonStreetName { get; set; }
        public string SalespersonAppartment { get; set; }
        [Required(ErrorMessage = "Salesperson City Required")]
        [MinLength(1, ErrorMessage = "Salesperson City Minimum Length 1")]
        [MaxLength(30, ErrorMessage = "Salesperson City Maximum Length 30")]
        public string SalespersonCity { get; set; }
        [Required(ErrorMessage = "Salesperson Province Required")]
        [MinLength(2, ErrorMessage = "Salesperson Province Minimum Length 2")]
        [MaxLength(2, ErrorMessage = "Salesperson Province Maximum Length 2")]
        public string SalespersonProvince { get; set; }
        [Required(ErrorMessage = "Salesperson Postal Code Required")]
        [MinLength(1, ErrorMessage = "Salesperson Postal Code Minimum Length 1")]
        [MaxLength(6, ErrorMessage = "Salesperson Postal Code Maximum Length 6")]
        public int LocationId { get; set; }
        public Nullable<bool> SalespersonIsActive { get; set; }
    }
}
