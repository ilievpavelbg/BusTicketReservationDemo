using BusTicketReservationDemoCORE.Data;
using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservationDemoCORE.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstrains.CustomerConstants.FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(DataConstrains.CustomerConstants.LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(DataConstrains.CustomerConstants.PhoneMaxLength)]
        public string Phone { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [StringLength(DataConstrains.CustomerConstants.AgeMaxLength)]
        public int? Age { get; set; }

        public Gender? Gender { get; set; } = null!;

        [StringLength(DataConstrains.CustomerConstants.TownMaxLength)]
        public string? Town { get; set; } = null!;

        [StringLength(DataConstrains.CustomerConstants.AddressMaxLength)]
        public string? Address { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
    }
}
