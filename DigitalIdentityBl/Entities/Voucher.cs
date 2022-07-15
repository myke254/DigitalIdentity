using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalIdentity.Data.Entities
{
    public class Voucher
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string? FirstName { get; set; }
        [Required]

        public string? LastName { get; set; }
        [Required]

        public string? Designation { get; set; }
        [Required]

        public string? IdNumber { get; set; }
        [Required]

        public string? Phone { get; set; }
        [Required]
        // Foreign key to Location
        [ForeignKey("Location")]
        public Guid LocationRefId { get; set; }
        public  Location? Location { get; set; }

        [Required]
        public Gender gender { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
