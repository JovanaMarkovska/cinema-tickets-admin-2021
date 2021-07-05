using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketsAdmin_2021.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public CinemaTicketsUser User { get; set; }

        public IEnumerable<TicketsInOrder> TicketsInOrder { get; set; }
    }
}
