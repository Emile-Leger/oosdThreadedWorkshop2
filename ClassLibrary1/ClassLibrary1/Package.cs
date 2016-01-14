using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class Package
    {
        public int PackageId{ get; set;}  // Pk fk in Table Bookings and Packages_Products_Suppliers 
        public String PkgName{get;set;}
        public DateTime PkgStartDate{get;set;}
        public DateTime PkgEndDate{get;set;}
        public String PkgDesc{get;set;}
        public Decimal PkgBasePrice{get;set;}
        public Decimal PkgAgencyCommission { get; set; }
    }
}
