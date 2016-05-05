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
    public class TXBatchConfiguration : EntityTypeConfiguration<TXBatch>
    {
        public TXBatchConfiguration()
        {
            ToTable("TXBatch");
            HasKey(p => p.TXBatchId);
            Property(p => p.TXBatchId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TXCodeId).IsOptional().HasMaxLength(10);
            Property(p => p.Description).IsOptional().HasMaxLength(255);
            Property(p => p.InsPlanId).IsOptional().HasMaxLength(10);
            Property(p => p.AdjudicationDate).IsOptional();
            Property(p => p.PayerReference).IsOptional().HasMaxLength(60);
            Property(p => p.Amount).IsRequired().HasPrecision(18, 2);
            Property(p => p.DepositDate).IsOptional();
            Property(p => p.ReadyToClose).IsRequired();
            Property(p => p.ClosedDateTime).IsOptional();
            Property(p => p.CreatedDateTime).IsRequired();
            Property(p => p.UserId).IsRequired().HasMaxLength(255);
            Property(p => p.ReceivedDate).IsOptional();
            Property(p => p.PaymentFormId).IsOptional().HasMaxLength(10);
            Property(p => p.ClosingRunId).IsOptional();
            Property(p => p.PostingPeriodId).IsOptional().HasMaxLength(10);

            // parents
            HasOptional(p => p.TXCode).WithMany(p => p.TXBatches).HasForeignKey(p => p.TXCodeId).WillCascadeOnDelete(false);
            HasRequired(p => p.User).WithMany(p => p.TXBatches).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasOptional(p => p.InsPlan).WithMany(p => p.TXBatches).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
            HasOptional(p => p.PaymentForm).WithMany(p => p.TXBatches).HasForeignKey(p => p.PaymentFormId).WillCascadeOnDelete(false);
            HasOptional(p => p.ClosingRun).WithMany(p => p.TXBatches).HasForeignKey(p => p.ClosingRunId).WillCascadeOnDelete(false);
            HasOptional(p => p.PostingPeriod).WithMany(p => p.TXBatches).HasForeignKey(p => p.PostingPeriodId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.TXMasters).WithRequired(c => c.TXBatch);
            HasMany(c => c.EDI835s).WithOptional(c => c.TxBatch);
        }
    }
}
