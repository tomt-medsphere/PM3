using PM3.Model.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class BillingAccountConfiguration : EntityTypeConfiguration<BillingAccount>
    {
        public BillingAccountConfiguration()
        {
            ToTable("BillingAccount");
            HasKey(p => p.BillingAccountId);
            Property(p => p.BillingAccountId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.GuarantorId).IsRequired().HasColumnAnnotation("Index", new IndexAttribute());
            Property(p => p.BillingAccountTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.BillingAccountTypeDate).IsRequired();
            Property(p => p.Description).HasMaxLength(100);
            Property(p => p.Inactive).IsRequired();

            // parents
            HasRequired(p => p.Guarantor).WithMany(p => p.BillingAccounts).HasForeignKey(p => p.GuarantorId).WillCascadeOnDelete(false);
            HasRequired(p => p.BillingAccountType).WithMany(p => p.BillingAccounts).HasForeignKey(p => p.BillingAccountTypeId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.Charges).WithRequired(c => c.BillingAccount);
            HasMany(c => c.PatientBillingAccounts).WithRequired(c => c.BillingAccount);
            HasMany(c => c.StatementRunDetails).WithRequired(c => c.BillingAccount);
            HasMany(c => c.ChargeServices).WithRequired(c => c.BillingAccount);
        }
    }
}
