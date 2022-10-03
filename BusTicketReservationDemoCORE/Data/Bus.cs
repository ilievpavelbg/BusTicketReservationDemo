using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicketReservationDemoCORE.Models
{
    public class Bus
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(DataConstrains.BusConstants.ModelMaxLength)]
        public string Model { get; set; } = null!;

        [Required]
        [StringLength(DataConstrains.BusConstants.TypeMaxLength)]
        public string Type { get; set; } = null!;

        public bool IsAvailiable { get; set; }

        [Required]
        [StringLength(DataConstrains.BusConstants.RegNumberMaxLength)]
        public string RegNumber { get; set; } = null!;

        [Required]
        [Range(DataConstrains.BusConstants.CapasityMin, DataConstrains.BusConstants.CapasityMax)]
        public int Capacity { get; set; }

        [Required]
        [ForeignKey(nameof(BusOwner))]
        public string BusOwnerId { get; set; } = null!;
        public virtual BusOwner BusOwner { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
        public virtual ICollection<Seat> Seats { get; set; } = new HashSet<Seat>();
    }
}
