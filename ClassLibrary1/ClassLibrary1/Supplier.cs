using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class Supplier
    {
        public int SupplierID { get; set; } // Pk fk in Table SupplierContacts & Products_Suppliers
        public String SupName { get; set; }
    }
}
