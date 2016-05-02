using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class MSPTypeConfiguration : EntityTypeConfiguration<MSPType>
    {
        public MSPTypeConfiguration()
        {
            ToTable("MSPType");
            HasKey(p => p.MSPTypeId);
            Property(p => p.MSPTypeId).IsRequired().HasMaxLength(5);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.InsPlans).WithOptional(c => c.MSPType);
        }
    }
}
