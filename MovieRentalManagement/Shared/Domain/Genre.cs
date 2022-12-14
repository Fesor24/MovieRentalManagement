using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Shared.Domain
{
    public class Genre: BaseClass
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<Movie>? Movies { get; set; }

    }
}
