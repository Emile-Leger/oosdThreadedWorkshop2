using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// coding doug sraega
/// <summary>
/// entity class Package Product Supplier
/// </summary>
namespace TravelExpertsDB
{
    public class Package_Product_Supplier
    {
        public int PackageId { get; set; }          // pk  pk in Table Packages
        public int ProductSupplierId { get; set; }   // pk  pk in Products_Suppliers
    }
}
