using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class StatementRunStatusConfiguration : EntityTypeConfiguration<StatementRunStatus>
    {
        public StatementRunStatusConfiguration()
        {
            ToTable("StatementRunStatus");
            HasKey(p => p.StatementRunStatusId);
            Property(p => p.StatementRunStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.StatementRuns).WithRequired(c => c.StatementRunStatus);
        }
    }
}
