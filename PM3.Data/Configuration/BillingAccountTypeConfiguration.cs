using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class BillingAccountTypeConfiguation : EntityTypeConfiguration<BillingAccountType>
    {
        public BillingAccountTypeConfiguation()
        {
            ToTable("BillingAccountType");
            HasKey(p => p.BillingAccountTypeId);
            Property(p => p.BillingAccountTypeId)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() {IsClustered = true}));
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.Billable).IsRequired();
            Property(p => p.Dunning).IsRequired();
            Property(p => p.Inactive).IsRequired();

            // parents

            // children
            HasMany(c => c.BillingAccounts).WithRequired(c => c.BillingAccountType);
        }
    }
}
