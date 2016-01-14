using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class Package_Product_Supplier
    {
        public int PackageId { get; set; }          // pk  pk in Table Packages
        public int PoductSupplierId { get; set; }   // pk  pk in Products_Suppliers
    }
}
