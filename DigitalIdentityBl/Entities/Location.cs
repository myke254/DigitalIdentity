using System.ComponentModel.DataAnnotations;

namespace DigitalIdentity.Data.Entities
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }
        public string? AdministrativeArea { get; set; }
    }
}
