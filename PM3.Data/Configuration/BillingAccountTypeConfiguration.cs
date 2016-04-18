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
    public class BillingAccountTypeConfiguation : EntityTypeConfiguration<BillingAccountType>
    {
        public BillingAccountTypeConfiguation()
        {
            ToTable("BillingAccountType");
            HasKey(p => p.BillingAccountTypeID);
            Property(p => p.BillingAccountTypeID).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(60);
            Property(p => p.Billable).IsRequired();
            Property(p => p.Dunning).IsRequired();
            Property(p => p.Inactive).IsRequired();
        }
    }
}
