using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Shared.Domain
{
    public class Movie: BaseClass
    {
        public int Year { get; set; }
        public int GenreId { get; set; }
        public int IndustryId { get; set; }
        public virtual Genre? Genre { get; set; }
        public virtual Industry? Industry { get; set; }
        public string MovieRecordNumber { get; set; } = string.Empty;
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
        public double RentalRate { get; set; }
    }
}
