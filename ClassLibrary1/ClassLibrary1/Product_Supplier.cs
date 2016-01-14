using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    //Enity class library for the Product_Suppliers Table
    // use this to get a row from the table into P
    public class Product_Supplier
    {
        public int ProductSupplierId{ get; set; }
        public int ProductId{get; set;}
        public int SupplierId{get; set;}
    }
}
