using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data.Configuration
{
    public class BillingAccountConfiguation : EntityTypeConfiguration<BillingAccount>
    {
        public BillingAccountConfiguation()
        {
            ToTable("BillingAccount");
            HasKey(p => p.BillingAccountID);
            Property(p => p.BillingAccountID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.GuarantorID).IsRequired();
            Property(p => p.BillingAccountTypeID).IsRequired().HasMaxLength(8);
            Property(p => p.BillingAccountTypeDate).IsRequired();
            Property(p => p.Description).HasMaxLength(60);
            Property(p => p.Inactive).IsRequired();
        }
    }
}
