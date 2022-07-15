using DigitalIdentity.Data.Entities;

namespace DigitalIdentity.Data.Databases.Interfaces
{
    public interface ISqlVoucher
    {
        List<Voucher> GetAllVouchers();
        Voucher GetVoucher(Guid id);
        void DeleteVoucher(Voucher voucher);
        Voucher UpdateVoucher(Voucher voucher);
        Voucher CreateVoucher(Voucher voucher);

    }
}
