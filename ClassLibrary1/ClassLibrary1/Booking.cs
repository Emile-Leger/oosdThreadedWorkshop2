using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class Booking
    {
        public int BookingId { get; set; }      // pk  fk in Table BookinDetails 
        public DateTime BookingDate { get; set; }
        public String BookingNo { get; set; }
        public double TravelerCount { get; set; }
        public int CustomerId { get; set; }     // fk  pk in Table Customers
        public String TripTypeId { get; set; }  // fk  pk in Table TripTypeId
        public int PackageId { get; set; }      // fk  pk in Table Packages
    }
}
