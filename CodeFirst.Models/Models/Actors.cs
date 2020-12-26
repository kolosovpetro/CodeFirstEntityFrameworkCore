using System;
using System.Collections.Generic;

namespace CodeFirst.Models.Models
{
    public class Actors
    {
        public int ActorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }


        // navigational properties
        // this is composite key to get many to many movies - actors
        public virtual ICollection<Starring> Starring { get; set; }
    }
}