using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicketReservationDemoCORE.Models
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime DateOfBooking { get; set; }

        [Required]
        [StringLength(DataConstrains.BookingConstants.BookingNumberMaxLength)]
        public string BookingNumber { get; set; } = null!;

        [StringLength(DataConstrains.BookingConstants.DescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
