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
    public class PrepErrorConfiguration : EntityTypeConfiguration<PrepError>
    {
        public PrepErrorConfiguration()
        {
            ToTable("PrepError");
            HasKey(p => p.PrepErrorId);
            Property(p => p.PrepErrorId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.ChargeServiceId).IsOptional();
            Property(p => p.PrepRuleId).IsRequired();
            Property(p => p.ChargeInsCoverageId).IsOptional();
            Property(p => p.ErrorNote).IsRequired().HasMaxLength(255);
            Property(p => p.CorrectedDateTime).IsOptional();
            Property(p => p.UserId).IsRequired();
            Property(p => p.OnDemand).IsRequired();

            // parents
            HasRequired(p => p.Charge).WithMany(p => p.PrepErrors).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasOptional(p => p.ChargeService).WithMany(p => p.PrepErrors).HasForeignKey(p => p.ChargeServiceId).WillCascadeOnDelete(false);
            HasOptional(p => p.ChargeInsCoverage).WithMany(p => p.PrepErrors).HasForeignKey(p => p.ChargeInsCoverageId).WillCascadeOnDelete(false);
            HasRequired(p => p.User).WithMany(p => p.PrepErrors).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
        }
    }
}
