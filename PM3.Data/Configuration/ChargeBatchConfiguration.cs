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
    public class ChargeBatchConfiguration : EntityTypeConfiguration<ChargeBatch>
    {
        public ChargeBatchConfiguration()
        {
            ToTable("ChargeBatch");
            HasKey(p => p.ChargeBatchId);
            Property(p => p.ChargeBatchId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PostingPeriodId).IsRequired().HasMaxLength(10);
            Property(p => p.PracticeSiteId).IsOptional().HasMaxLength(10);
            Property(p => p.Description).IsOptional().HasMaxLength(100);
            Property(p => p.Amount).IsOptional();
            Property(p => p.CreatedDateTime).IsRequired();
            Property(p => p.ClosedDateTime).IsOptional();
            Property(p => p.ReadyToClose).IsRequired();
            Property(p => p.ClosingRunId).IsOptional();
            Property(p => p.UserId).IsRequired().HasMaxLength(255);

            // parents
            HasRequired(p => p.PostingPeriod).WithMany(p => p.ChargeBatches).HasForeignKey(p => p.PostingPeriodId).WillCascadeOnDelete(false);
            HasRequired(p => p.User).WithMany(p => p.ChargeBatches).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasOptional(p => p.PracticeSite).WithMany(p => p.ChargeBatches).HasForeignKey(p => p.PracticeSiteId).WillCascadeOnDelete(false);
            HasOptional(p => p.PostingPeriod).WithMany(p => p.ChargeBatches).HasForeignKey(p => p.PostingPeriodId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.Charges).WithRequired(c => c.ChargeBatch);
        }
    }
}
