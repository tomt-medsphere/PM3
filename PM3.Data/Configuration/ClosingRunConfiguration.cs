using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ClosingRunConfiguration : EntityTypeConfiguration<ClosingRun>
    {
        public ClosingRunConfiguration()
        {
            ToTable("ClosingRun");
            HasKey(p => p.ClosingRunId);
            Property(p => p.ClosingRunId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ClosingRunDateTime).IsRequired();
            Property(p => p.Description).IsOptional().HasMaxLength(100);
            Property(p => p.UserId).IsRequired().HasMaxLength(255);

            // parents
            HasRequired(p => p.User).WithMany(p => p.ClosingRuns);

            // children
            HasMany(c => c.TXBatches).WithRequired(c => c.ClosingRun);
            HasMany(c => c.ChargeBatches).WithRequired(c => c.ClosingRun);
        }
    }
}
