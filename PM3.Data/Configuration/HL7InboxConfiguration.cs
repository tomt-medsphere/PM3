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
    public class HL7InboxConfiguration : EntityTypeConfiguration<HL7Inbox>
    {
        public HL7InboxConfiguration()
        {
            ToTable("HL7Inbox");
            HasKey(p => p.HL7InboxId);
            Property(p => p.HL7InboxId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Received).IsRequired();
            Property(p => p.Processed).IsOptional();
            Property(p => p.MessageType).IsRequired().HasMaxLength(10);
            Property(p => p.EventId).IsRequired().HasMaxLength(10);
            Property(p => p.Message).IsRequired().HasColumnType("longtext");
            Property(p => p.HL7OutBoxId).IsOptional();

            // parents
            HasOptional(p => p.AcknowledgesHL7Outbox).WithOptionalDependent(p => p.AcknowledgedBy).WillCascadeOnDelete(false);
        }
    }
}
