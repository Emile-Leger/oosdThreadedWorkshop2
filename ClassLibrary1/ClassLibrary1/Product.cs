using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class Product
    {
        public int ProductId { get; set; } // pk   fk in Table Product_Suppliers
        public string ProdName { get; set; }

        public override string ToString()
        {
            return ProdName;
        }
    }
}
