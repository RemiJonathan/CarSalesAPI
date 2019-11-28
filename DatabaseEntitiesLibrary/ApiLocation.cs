using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntitiesLibrary
{
    public class ApiLocation
    {
        public int LocationId { get; set; }
        public string LocationAddressCivicNo { get; set; }
        public string LocationAddressStreetName { get; set; }
        public string LocationAddressAppartment { get; set; }
        public string LocationAddressCity { get; set; }
        public string LocationAddressProvince { get; set; }
        public string LocationAddressPostalCode { get; set; }
        public Nullable<bool> LocationIsActive { get; set; }
    }
}
