using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Shared.Domain
{
    public class Industry: BaseClass
    {
        public string Name { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; }
    }
}
