using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Shared.Domain
{
    public class Customer: BaseClass
    {
        [Required(ErrorMessage ="First Name is a required field")]
        [StringLength(100, MinimumLength =2)]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage ="Last Name is a required field")]
        [StringLength(100, MinimumLength =2)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [StringLength(15)]
        public string TaxId { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;
        public int BookingId { get; set; }
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
