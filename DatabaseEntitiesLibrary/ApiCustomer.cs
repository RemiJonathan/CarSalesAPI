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
        public string CustomerFName { get; set; }
        public string CustomerLName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddressCivicNo { get; set; }
        public string CustomerAddressStreetName { get; set; }
        public string CustomerAddressAppartment { get; set; }
        public string CustomerAddressCity { get; set; }
        public string CustomerAddressProvince { get; set; }
        public string CustomerAddressPostalCode { get; set; }
        public bool CustomerIsActive { get; set; }
    }
}
