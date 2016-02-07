using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    //Enity class library for the Product_Suppliers Table
    // use this to get a row from the table Product Supplier
    /// <summary>
    /// entity class  Product Suppluer
    /// </summary>
    public class Product_Supplier
    {
        public int ProductSupplierId{ get; set; }
        public int ProductId{get; set;}
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public string SupName { get; set; }

        public override string ToString()
        {
            return ProductName + " by " + SupName;
        }
    }
}
