using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ClaimRunStatusConfiguration : EntityTypeConfiguration<ClaimRunStatus>
    {
        public ClaimRunStatusConfiguration()
        {
            ToTable("ClaimRunStatus");
            HasKey(p => p.ClaimRunStatusId);
            Property(p => p.ClaimRunStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            //children
            HasMany(c => c.ClaimRuns).WithRequired(c => c.ClaimRunStatus);
        }
    }
}
