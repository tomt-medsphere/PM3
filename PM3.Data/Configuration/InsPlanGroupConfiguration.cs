using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class InsPlanGroupConfiguration : EntityTypeConfiguration<InsPlanGroup>
    {
        public InsPlanGroupConfiguration()
        {
            ToTable("InsPlanGroup");
            HasKey(p => p.InsPlanGroupId);
            Property(p => p.InsPlanGroupId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(60);
            Property(p => p.Note).IsOptional().HasColumnType("text");
            Property(p => p.Inactive).IsRequired();

            // children
            HasMany(c => c.InsPlans).WithOptional(c => c.InsPlanGroup);
            HasMany(c => c.PlanProfiles).WithOptional(c => c.InsPlanGroup);
        }
    }
}
