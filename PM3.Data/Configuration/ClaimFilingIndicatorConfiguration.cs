using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ClaimFilingIndicatorConfiguration : EntityTypeConfiguration<ClaimFilingIndicator>
    {
        public ClaimFilingIndicatorConfiguration()
        {
            ToTable("ClaimFilingIndicator");
            HasKey(p => p.ClaimFilingIndicatorId);
            Property(p => p.ClaimFilingIndicatorId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.InsPlans).WithRequired(c => c.ClaimFilingIndicator);
        }
    }
}
