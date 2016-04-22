using PM3.Model.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class BillingAccountConfiguation : EntityTypeConfiguration<BillingAccount>
    {
        public BillingAccountConfiguation()
        {
            ToTable("BillingAccount");
            HasKey(p => p.BillingAccountId);
            Property(p => p.BillingAccountId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.GuarantorId).IsRequired();
            Property(p => p.BillingAccountTypeId).IsRequired().HasMaxLength(8);
            Property(p => p.BillingAccountTypeDate).IsRequired();
            Property(p => p.Description).HasMaxLength(60);
            Property(p => p.Inactive).IsRequired();
        }
    }
}
