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
    public class StatementRunConfiguration : EntityTypeConfiguration<StatementRun>
    {
        public StatementRunConfiguration()
        {
            ToTable("StatementRun");
            HasKey(p => p.StatementRunId);
            Property(p => p.StatementRunId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.StatementRunDateTime).IsRequired();
            Property(p => p.EDI).IsRequired();
            Property(p => p.StatementRunStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.UserId).IsRequired().HasMaxLength(255);

            // parents
            HasRequired(p => p.User).WithMany(p => p.StatementRuns).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.StatementRunStatus).WithMany(p => p.StatementRuns).HasForeignKey(p => p.StatementRunStatusId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.StatementRunDetails).WithRequired(c => c.StatementRun);
            HasMany(c => c.EDISessionSteps).WithOptional(c => c.StatementRun);
        }
    }
}
