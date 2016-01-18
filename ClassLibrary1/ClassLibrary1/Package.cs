using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class Package
    {
        public int PackageId { get; set; }  // Pk fk in Table Bookings and Packages_Products_Suppliers 
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }
        public byte[] PkgImg;
        public List<Product_Supplier> productSuppliers;

        public override string ToString()
        {
            return PkgName;
        }

        public void fillSuppliers()
        {
            productSuppliers = TravelExpertsDB.getProductSuppliers(PackageId);
        }        
    }
}
