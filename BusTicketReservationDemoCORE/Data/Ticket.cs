using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicketReservationDemoCORE.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "100")]
        public decimal Price { get; set; }

        [StringLength(DataConstrains.TicketConstants.AgeDiscountMaxLength)]
        public int? AgeDiscount { get; set; }

        [StringLength(DataConstrains.TicketConstants.CommentMaxLength)]
        public string? Comments { get; set; }
        
        public bool IsActive { get; set; }

        [ForeignKey(nameof(Booking))]
        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; } = null!;

        [ForeignKey(nameof(Bus))]
        public int BusId { get; set; }
        public virtual Bus Bus { get; set; } = null!;

        [ForeignKey(nameof(Destination))]
        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; } = null!;
    }
}
