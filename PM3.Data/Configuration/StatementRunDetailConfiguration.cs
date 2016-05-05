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
    public class StatementRunDetailConfiguration : EntityTypeConfiguration<StatementRunDetail>
    {
        public StatementRunDetailConfiguration()
        {
            ToTable("StatementRunDetail");
            HasKey(p => p.StatementRunDetailId);
            Property(p => p.StatementRunDetailId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.StatementRunId).IsRequired();
            Property(p => p.BillingAccountId).IsRequired();
            Property(p => p.StatementData).IsRequired().HasColumnType("longtext");

            // parents
            HasRequired(p => p.StatementRun).WithMany(p => p.StatementRunDetails).HasForeignKey(p => p.StatementRunId).WillCascadeOnDelete(false);
            HasRequired(p => p.BillingAccount).WithMany(p => p.StatementRunDetails).HasForeignKey(p => p.BillingAccountId).WillCascadeOnDelete(false);
        }
    }
}
