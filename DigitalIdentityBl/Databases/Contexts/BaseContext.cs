using System.ComponentModel.DataAnnotations;

namespace DigitalIdentity.Data.Databases.Contexts
{
    public class BaseContext
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
