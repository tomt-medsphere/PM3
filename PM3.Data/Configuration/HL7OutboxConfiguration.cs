using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class HL7OutboxConfiguration : EntityTypeConfiguration<HL7Outbox>
    {
        public HL7OutboxConfiguration()
        {
            ToTable("Hl7Outbox");
            HasKey(p => p.HL7OutboxId);
            Property(p => p.HL7OutboxId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Created).IsRequired();
            Property(p => p.Sent).IsOptional();
            Property(p => p.ReceivingApplication).IsRequired().HasMaxLength(100);
            Property(p => p.MessageType).IsRequired().HasMaxLength(10);
            Property(p => p.EventId).IsRequired().HasMaxLength(10);
            Property(p => p.Message).IsRequired().HasColumnType("longtext");
            Property(p => p.Result).IsOptional().HasColumnType("longtext");          
        }
    }
}
