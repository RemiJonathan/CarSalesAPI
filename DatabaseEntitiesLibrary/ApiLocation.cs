using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEntitiesLibrary
{
    public class ApiLocation
    {
        [Key]
        public int LocationId { get; set; }
        [Required(ErrorMessage = "Location Address Civic No Required")]
        [MinLength(1, ErrorMessage = "Location Address Civic No Minimum Length 1")]
        [MaxLength(10, ErrorMessage = "Location Address Civic No Maximum Length 10")]
        public string LocationAddressCivicNo { get; set; }
        [Required(ErrorMessage = "Location Address Street Name Required")]
        [MinLength(1, ErrorMessage = "Location Address Street Name Minimum Length 1")]
        [MaxLength(20, ErrorMessage = "Location Address Street Name Maximum Length 20")]
        public string LocationAddressStreetName { get; set; }
        public string LocationAddressAppartment { get; set; }
        [Required(ErrorMessage = "Location Address City Required")]
        [MinLength(1, ErrorMessage = "Location Address City Minimum Length 1")]
        [MaxLength(30, ErrorMessage = "Location Address City Maximum Length 30")]
        public string LocationAddressCity { get; set; }
        [Required(ErrorMessage = "Location Address Province Required")]
        [MinLength(1, ErrorMessage = "Location Address Province Minimum Length 1")]
        [MaxLength(2, ErrorMessage = "Location Address Province Maximum Length 2")]
        public string LocationAddressProvince { get; set; }
        [Required(ErrorMessage = "Location Address Postal Code Required")]
        [MinLength(1, ErrorMessage = "Location Address Postal Code Minimum Length 1")]
        [MaxLength(6, ErrorMessage = "Location Address Postal Code Maximum Length 6")]
        public string LocationAddressPostalCode { get; set; }
        public Nullable<bool> LocationIsActive { get; set; }
    }
}
