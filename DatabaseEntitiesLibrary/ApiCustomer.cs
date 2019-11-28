using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntitiesLibrary
{
    public class ApiCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerFname { get; set; }
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
