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
    public class EDISessionConfiguration : EntityTypeConfiguration<EDISession>
    {
        public EDISessionConfiguration()
        {
            ToTable("EDISession");
            HasKey(p => p.EDISessionId);
            Property(p => p.EDISessionId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EDIPartnerId).IsRequired().HasMaxLength(10);
            Property(p => p.EDISessionDateTime).IsRequired();
            Property(p => p.EDISessionStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.UserId).IsRequired().HasMaxLength(255);

            // parents
            HasRequired(p => p.EDIPartner).WithMany(p => p.EDISessions).HasForeignKey(p => p.EDIPartnerId).WillCascadeOnDelete(false);
            HasRequired(p => p.EDISessionStatus).WithMany(p => p.EDISessions).HasForeignKey(p => p.EDISessionStatusId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.EDIInboxes).WithOptional(c => c.EDISession);
            HasMany(c => c.EDISessionSteps).WithRequired(c => c.EDISession);
        }
    }
}
