using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class InsFormTypeConfiguration : EntityTypeConfiguration<InsFormType>
    {
        public InsFormTypeConfiguration()
        {
            ToTable("InsFormType");
            HasKey(p => p.InsFormTypeId);
            Property(p => p.InsFormTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.InsPlans).WithRequired(c => c.InsFormType);
            HasMany(c => c.Claims).WithRequired(c => c.InsFormType);
            HasMany(c => c.PrepRunDetails).WithRequired(c => c.InsFormType);
            HasMany(c => c.ClaimRuns).WithRequired(c => c.InsFormType);
        }
    }
}
