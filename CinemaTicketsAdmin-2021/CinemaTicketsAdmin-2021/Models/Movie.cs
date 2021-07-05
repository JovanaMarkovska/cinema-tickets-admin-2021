using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketsAdmin_2021.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
