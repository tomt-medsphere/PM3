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
    public class ClaimConfiguration : EntityTypeConfiguration<Claim>
    {
        public ClaimConfiguration()
        {
            ToTable("Claim");
            HasKey(p => p.ClaimId);
            Property(p => p.ClaimId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.PrepRunId).IsRequired();
            Property(p => p.ChargeInsCoverageId).IsRequired();
            Property(p => p.InsPlanId).IsRequired().HasMaxLength(10);
            Property(p => p.EDIPartnerId).IsOptional().HasMaxLength(10);
            Property(p => p.InsFormTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.ClaimRunId).IsOptional();
            Property(p => p.BillingProviderTIN).IsRequired().HasMaxLength(30);
            Property(p => p.BillingProviderNPI).IsRequired().HasMaxLength(30);
            Property(p => p.TotalFee).IsRequired();
            Property(p => p.BilledFee).IsRequired();
            Property(p => p.Suppress).IsRequired();
            Property(p => p.ClaimStatusDate).IsOptional();
            Property(p => p.ClaimActionCode).IsOptional().HasMaxLength(10);
            Property(p => p.ClaimICN).IsOptional().HasMaxLength(50);

            // parents
            HasRequired(p => p.PrepRun).WithMany(p => p.Claims).HasForeignKey(p => p.PrepRunId).WillCascadeOnDelete(false);
            HasRequired(p => p.Charge).WithMany(p => p.Claims).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasRequired(p => p.ChargeInsCoverage).WithMany(p => p.Claims).HasForeignKey(p => p.ChargeInsCoverageId).WillCascadeOnDelete(false);
            HasRequired(p => p.EDIPartner).WithMany(p => p.Claims).HasForeignKey(p => p.EDIPartnerId).WillCascadeOnDelete(false);
            HasRequired(p => p.InsFormType).WithMany(p => p.Claims).HasForeignKey(p => p.InsFormTypeId).WillCascadeOnDelete(false);
            HasRequired(p => p.InsPlan).WithMany(p => p.Claims).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
            HasOptional(p => p.ClaimRun).WithMany(p => p.Claims).HasForeignKey(p => p.ClaimRunId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.EDI277STCs).WithRequired(c => c.Claim);
        }
    }
}
