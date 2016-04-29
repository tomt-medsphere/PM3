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
    public class ClaimRunConfiguration : EntityTypeConfiguration<ClaimRun>
    {
        public ClaimRunConfiguration()
        {
            ToTable("ClaimRun");
            HasKey(p => p.ClaimRunId);
            Property(p => p.ClaimRunId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.CreatedDateTime).IsRequired();
            Property(p => p.UserId).IsRequired().HasMaxLength(255);
            Property(p => p.EDIPartnerId).IsOptional().HasMaxLength(10);
            Property(p => p.InsFormTypeId).IsOptional().HasMaxLength(10);
            Property(p => p.ClaimRunStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.SubmittedDateTime).IsOptional();
            Property(p => p.AcknowledgedDateTime).IsOptional();
            Property(p => p.ClaimsProcessed).IsRequired();
            Property(p => p.ClaimsGenerated).IsRequired();
            Property(p => p.Note).IsOptional().HasMaxLength(100);
            Property(p => p.ClaimTransactionSet).IsOptional().HasColumnType("longtext");

            // parents
            HasRequired(p => p.User).WithMany(p => p.ClaimRuns);
            HasRequired(p => p.ClaimRunStatus).WithMany(p => p.ClaimRuns);
            HasOptional(p => p.EDIPartner).WithMany(p => p.ClaimRuns);
            HasOptional(p => p.InsFormType).WithMany(p => p.ClaimRuns);
            
            // children
            HasMany(c => c.EDI277s).WithOptional(c => c.ClaimRun);
            HasMany(c => c.EDISessionSteps).WithOptional(c => c.ClaimRun);
            HasMany(c => c.Claims).WithOptional(c => c.ClaimRun);
        }
    }
}
