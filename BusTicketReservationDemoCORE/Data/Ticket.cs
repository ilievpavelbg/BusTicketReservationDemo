using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservationDemoCORE.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public int AgeDiscount { get; set; }
        public string? Comments { get; set; }
        public int BookingId { get; set; }
        public int BusId { get; set; }
        public int DestinationId { get; set; }
        public bool? IsValid { get; set; }

        public virtual Booking Booking { get; set; } = null!;
        public virtual Bus Bus { get; set; } = null!;
        public virtual Destination Destination { get; set; } = null!;
    }
}
