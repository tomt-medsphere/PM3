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
    public class PrepRunDetailConfiguration : EntityTypeConfiguration<PrepRunDetail>
    {
        public PrepRunDetailConfiguration()
        {
            ToTable("PrepRunDetail");
            HasKey(p => p.PrepRunDetailId);
            Property(p => p.PrepRunDetailId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PrepRunId).IsRequired();
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.InsPlanId).IsOptional().HasMaxLength(10);
            Property(p => p.FirstDateOfService).IsRequired();
            Property(p => p.TotalFee).IsRequired().HasPrecision(18, 2);
            Property(p => p.BilledFee).IsRequired().HasPrecision(18, 2);
            Property(p => p.PassedPrep).IsRequired().HasMaxLength(10);
            Property(p => p.EDIPartnerId).IsOptional().HasMaxLength(10);
            Property(p => p.InsFormTypeId).IsRequired().HasMaxLength(10);

            // parents
            HasRequired(p => p.PrepRun).WithMany(p => p.PrepRunDetails).HasForeignKey(p => p.PrepRunId).WillCascadeOnDelete(false);
            HasRequired(p => p.Charge).WithMany(p => p.PrepRunDetails).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasOptional(p => p.InsPlan).WithMany(p => p.PrepRunDetails).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
            HasOptional(p => p.EDIPartner).WithMany(p => p.PrepRunDetails).HasForeignKey(p => p.EDIPartnerId).WillCascadeOnDelete(false);
            HasRequired(p => p.InsFormType).WithMany(p => p.PrepRunDetails).HasForeignKey(p => p.InsFormTypeId).WillCascadeOnDelete(false);
        }
    }
}
