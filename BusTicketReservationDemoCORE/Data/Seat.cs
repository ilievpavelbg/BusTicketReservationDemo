using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservationDemoCORE.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(DataConstrains.SeatConstants.NumberMinLength, DataConstrains.SeatConstants.NumberMaxLength)]
        public int Number { get; set; }

        public bool IsBooked { get; set; }

        public virtual ICollection<Bus> Buses { get; set; } = new HashSet<Bus>();   
    }
}
