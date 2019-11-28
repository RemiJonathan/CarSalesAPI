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
        public string SalespersonCivicNo { get; set; }
        public string SalespersonStreetName { get; set; }
        public string SalespersonAppartment { get; set; }
        public string SalespersonCity { get; set; }
        public string SalespersonProvince { get; set; }
        public string SalespersonPostalCode { get; set; }
        public int LocationId { get; set; }
        public Nullable<bool> SalespersonIsActive { get; set; }
    }
}
