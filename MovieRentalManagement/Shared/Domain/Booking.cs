using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Shared.Domain
{
    public class Booking: BaseClass
    {
        public int MovieId { get; set; }
        public virtual Movie Movies { get; set; } = new Movie();
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customers { get; set; } = new Customer();
    }
}
