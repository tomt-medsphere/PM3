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
    public class EDIInboxConfiguration : EntityTypeConfiguration<EDIInbox>
    {
        public EDIInboxConfiguration()
        {
            ToTable("EDIInbox");
            HasKey(p => p.EDIInboxId);
            Property(p => p.EDIInboxId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ReceivedDateTime).IsRequired();
            Property(p => p.UserId).IsRequired().HasMaxLength(255);
            Property(p => p.FileText).IsOptional();
            Property(p => p.OriginalFileName).IsOptional().HasMaxLength(255);
            Property(p => p.EDISessionId).IsOptional();

            // parents
            HasRequired(p => p.User).WithMany(p => p.EDIInboxes).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasOptional(p => p.EDISession).WithMany(p => p.EDIInboxes).HasForeignKey(p => p.EDISessionId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.EDI835s).WithOptional(c => c.EDIInbox);
            HasMany(c => c.EDIReports).WithOptional(c => c.EDIInbox);
            HasMany(c => c.EDISessionSteps).WithOptional(c => c.EDIInbox);

        }
    }
}
