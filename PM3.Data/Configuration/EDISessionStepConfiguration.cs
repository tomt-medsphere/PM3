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
    public class EDISessionStepConfiguration : EntityTypeConfiguration<EDISessionStep>
    {
        public EDISessionStepConfiguration()
        {
            ToTable("EDISessionStep");
            HasKey(p => p.EDISessionStepId);
            Property(p => p.EDISessionStepId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EDISessionId).IsRequired();
            Property(p => p.EDISessionStageId).IsRequired();
            Property(p => p.Error).IsRequired();
            Property(p => p.ClaimRunId).IsOptional();
            Property(p => p.StatementRunId).IsOptional();
            Property(p => p.EDIInboxId).IsOptional();
            Property(p => p.Message).IsOptional();
            Property(p => p.Filename).IsOptional().HasMaxLength(255);

            // parents
            HasRequired(p => p.EDISession).WithMany(p => p.EDISessionSteps).HasForeignKey(p => p.EDISessionId).WillCascadeOnDelete(false);
            HasRequired(p => p.EDISessionStage).WithMany(p => p.EDISessionSteps).HasForeignKey(p => p.EDISessionStageId).WillCascadeOnDelete(false);
            HasOptional(p => p.EDIInbox).WithMany(p => p.EDISessionSteps).HasForeignKey(p => p.EDIInboxId).WillCascadeOnDelete(false);
            HasOptional(p => p.ClaimRun).WithMany(p => p.EDISessionSteps).HasForeignKey(p => p.ClaimRunId).WillCascadeOnDelete(false);
            HasOptional(p => p.StatementRun).WithMany(p => p.EDISessionSteps).HasForeignKey(p => p.StatementRunId).WillCascadeOnDelete(false);
        }
    }
}
