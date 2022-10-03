using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservationDemoCORE.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime StartHour { get; set; }

        [Required]
        [Range(DataConstrains.ScheduleConstants.DurationMinLength, DataConstrains.ScheduleConstants.DuratonMaxLength)]
        public int Duration { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; } = new HashSet<Destination>();    
    }
}
