using System;

namespace CodeFirst.Models.Models
{
    public class Rentals
    {
        public int CopyId { get; set; }
        public int ClientId { get; set; }
        public DateTime? DateOfRental { get; set; }
        public DateTime? DateOfReturn { get; set; }

        // navigational properties
        public virtual Clients Client { get; set; }
        public virtual Copies Copy { get; set; }
    }
}