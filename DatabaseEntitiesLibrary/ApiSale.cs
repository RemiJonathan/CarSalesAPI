using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntitiesLibrary
{
    public class ApiSale
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public int SalespersonId { get; set; }
        public int VehicleId { get; set; }
    }
}
