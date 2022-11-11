using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Shared.Domain
{
    public class Customer: BaseClass
    {
        public string TaxId { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public int BookingId { get; set; }
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
