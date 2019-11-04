using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntitiesLibrary
{
    public class ApiSalesperson
    {
        public int SalespersonId { get; set; }
        public string SalespersonFname { get; set; }
        public string SalespersonLname { get; set; }
        public string SalespersonEmail { get; set; }
        public string SalespersonPhone { get; set; }
        public string SalespersonAddressCivicNo { get; set; }
        public string SalespersonAddressStreetName { get; set; }
        public string SalespersonAddressAppartment { get; set; }
        public string SalespersonAddressCity { get; set; }
        public string SalespersonAddressProvince { get; set; }
        public string SalespersonAddressPostalCode { get; set; }
        public int LocationId { get; set; }
        public bool Active { get; set; }
    }
}
