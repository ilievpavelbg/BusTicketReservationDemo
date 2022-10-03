using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservationDemoCORE.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstrains.DestinationConstants.StartTownMaxLength)]
        public string StartTown { get; set; } = null!;

        [Required]
        [StringLength(DataConstrains.DestinationConstants.EndTownMaxLength)]
        public string EndTown { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();

        public virtual ICollection<Schedule> Schedules { get; set; } = new HashSet<Schedule>();
    }
}
