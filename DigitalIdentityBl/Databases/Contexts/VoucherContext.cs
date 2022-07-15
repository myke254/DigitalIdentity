using DigitalIdentity.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace DigitalIdentity.Data.Databases.Contexts
{
    public class VoucherContext : Voucher
    {
       
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
