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
    public class EDI835Configuration : EntityTypeConfiguration<EDI835>
    {
        public EDI835Configuration()
        {
            ToTable("EDI825");
            HasKey(p => p.EDI835Id);
            Property(p => p.EDI835Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EDIInboxId).IsOptional();
            Property(p => p.TXBatchId).IsOptional();
            Property(p => p.SenderId).IsOptional().HasMaxLength(60);
            Property(p => p.ReceiverId).IsOptional().HasMaxLength(60);
            Property(p => p.InterchangeDateTime).IsOptional();
            Property(p => p.InterchangeICN).IsOptional().HasMaxLength(30);
            Property(p => p.GroupDateTime).IsOptional();
            Property(p => p.GroupICN).IsOptional().HasMaxLength(30);
            Property(p => p.TransactionSetICN).IsOptional().HasMaxLength(30);
            Property(p => p.X12Version).IsRequired().HasMaxLength(30);
            Property(p => p.Amount).IsRequired();
            Property(p => p.PaymentMethod).IsOptional().HasMaxLength(10);
            Property(p => p.PaymentDate).IsOptional();
            Property(p => p.PaymentTraceNumber).IsOptional().HasMaxLength(30);
            Property(p => p.EDI835Text).IsRequired();
            Property(p => p.SegmentDelimiter).IsRequired().HasMaxLength(1);
            Property(p => p.ElementDelimiter).IsRequired().HasMaxLength(1);
            Property(p => p.SubElementDelimiter).IsRequired().HasMaxLength(1);

            // parents
            HasOptional(p => p.EDIInbox).WithMany(p => p.EDI835s).HasForeignKey(p => p.EDI835Id).WillCascadeOnDelete(false);
            HasOptional(p => p.TxBatch).WithMany(p => p.EDI835s).HasForeignKey(p => p.TXBatchId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.EDI835Log).WithRequired(c => c.EDI835);
        }
    }
}
