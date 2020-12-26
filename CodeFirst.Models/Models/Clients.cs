using System;
using System.Collections.Generic;

namespace CodeFirst.Models.Models
{
    public class Clients
    {
        public int ClientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }

        // navigational properties
        public virtual ICollection<Rentals> Rentals { get; set; }
    }
}