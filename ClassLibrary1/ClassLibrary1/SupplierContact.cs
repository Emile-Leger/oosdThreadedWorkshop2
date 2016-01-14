using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class SupplierContact
    {
        public int SupplierContactId {get;set;} // PK  not found in other table  use fk's 
        public string SupConFirstName {get;set;}
        public string SupConLastName {get;set;}
        public string SupConCompany {get;set;}
        public string SupConAddress {get;set;}
        public string SupConCity {get;set;}
        public string SupConProv {get;set;}
        public string SupConPostal {get;set;}
        public string SupConCountry {get;set;}
        public string SupConBusphone {get;set;}
        public string SupConFax {get;set;}
        public string SupConEmail {get;set;}
        public string SupConUrl {get;set;}
        public string AffiliationId {get;set;}  //FK  pk in Table Suppliers
        public int SupplierID {get;set;}        //FK  pk in Table Affiliations
    }
}
