using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketsAdmin_2021.Models
{
    public class Ticket
    {
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public Movie Movie { get; set; }
        public Guid MovieId { get; set; }
    
    }
}
