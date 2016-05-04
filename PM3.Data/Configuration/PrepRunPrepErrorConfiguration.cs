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
    public class PrepRunPrepErrorConfiguration : EntityTypeConfiguration<PrepRunPrepError>
    {
        public PrepRunPrepErrorConfiguration()
        {
            ToTable("PrepRunPrepError");
            HasKey(p => p.PrepRunPrepErrorId);
            Property(p => p.PrepRunPrepErrorId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PrepRunId).IsRequired();
            Property(p => p.PrepRuleId).IsRequired();
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.ChargeServiceId).IsOptional();
            Property(p => p.ChargeInsCoverageId).IsOptional();
            Property(p => p.Note).IsOptional().HasMaxLength(255);
            Property(p => p.OnDemand).IsRequired();

            // parents
            HasRequired(p => p.Charge).WithMany(p => p.PrepRunPrepErrors).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasRequired(p => p.PrepRun).WithMany(p => p.PrepRunPrepErrors).HasForeignKey(p => p.PrepRunId).WillCascadeOnDelete(false);
            HasRequired(p => p.PrepRule).WithMany(p => p.PrepRunPrepErrors).HasForeignKey(p => p.PrepRuleId).WillCascadeOnDelete(false);
            HasOptional(p => p.ChargeInsCoverage).WithMany(p => p.PrepRunPrepErrors).HasForeignKey(p => p.ChargeInsCoverageId).WillCascadeOnDelete(false);
        }
    }
}
