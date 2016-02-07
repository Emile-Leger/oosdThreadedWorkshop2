using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    
    // entity class supplier
    /// <summary>
    /// entity class Supplier
    /// </summary>
    public class Supplier
    {
        public int SupplierID { get; set; } // Pk fk in Table SupplierContacts & Products_Suppliers
        public string SupName { get; set; }

        public override string ToString()
        {
            return SupName;
        }        
    }
}
