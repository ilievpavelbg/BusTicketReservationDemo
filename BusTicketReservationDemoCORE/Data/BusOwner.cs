using BusTicketReservationDemoCORE.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace BusTicketReservationDemoCORE.Models
{
    public class BusOwner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstrains.BusOwnerConstants.CompanyNameMaxLength)]
        public string CompanyName { get; set; } = null!;

        [Required]
        [StringLength(DataConstrains.BusOwnerConstants.VATMaxLength)]
        public string VATnumber { get; set; } = null!;

        [StringLength(DataConstrains.BusOwnerConstants.TownMaxLength)]
        public string? Town { get; set; } = null!;

        [StringLength(DataConstrains.BusOwnerConstants.AddressMaxLength)]
        public string? Address { get; set; } = null!;

        [Required]
        [StringLength(DataConstrains.BusOwnerConstants.PhoneMaxLength)]
        public string Phone { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; } = null!;

        [StringLength(DataConstrains.BusOwnerConstants.ContactPersonMaxLength)]
        public string? ContactPerson { get; set; } = null!;

        [StringLength(DataConstrains.BusOwnerConstants.WebsiteMaxLength)]
        public string? WebSite { get; set; } = null!;

        [StringLength(DataConstrains.BusOwnerConstants.DirectorNameMaxLength)]
        public string? DirectorName { get; set; } = null!;

        public virtual ICollection<Bus> Buses { get; set; } = new HashSet<Bus>();
    }
}
