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
    public class InsPlanConfiguration : EntityTypeConfiguration<InsPlan>
    {
        public InsPlanConfiguration()
        {
            ToTable("InsPlan");
            HasKey(p => p.InsPlanId);
            Property(p => p.InsPlanId).IsRequired().HasMaxLength(10);
            Property(p => p.InsPlanGroupId).IsOptional().HasMaxLength(10);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.AddressStreet).IsRequired().HasMaxLength(55);
            Property(p => p.AddressOther).IsOptional().HasMaxLength(55);
            Property(p => p.City).IsRequired().HasMaxLength(30);
            Property(p => p.USPSStateId).IsRequired().HasMaxLength(2);
            Property(p => p.PostalCode).IsRequired().HasMaxLength(15);
            Property(p => p.USPSCountryId).IsRequired().HasMaxLength(2);
            Property(p => p.URL).IsOptional().HasMaxLength(255);
            Property(p => p.Contracted).IsRequired();
            Property(p => p.AcceptAssignment).IsRequired();
            Property(p => p.InsFormTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.MemberNumbers).IsRequired();
            Property(p => p.EDIMemberNumbers).IsRequired();
            Property(p => p.TimelyFilingDays).IsRequired();
            Property(p => p.SubmitZeros).IsRequired();
            Property(p => p.SupervisedBilling).IsRequired();
            Property(p => p.ICDYearStarts).IsRequired();
            Property(p => p.HPI).IsOptional().HasMaxLength(80);
            Property(p => p.EDIPartnerId).IsOptional().HasMaxLength(10);
            Property(p => p.ClaimsPayerId).IsOptional().HasMaxLength(10);
            Property(p => p.EligibilityPayerId).IsOptional().HasMaxLength(10);
            Property(p => p.ClaimFilingIndicatorId).IsOptional().HasMaxLength(10);
            Property(p => p.IdQualifierId).IsOptional().HasMaxLength(2);
            Property(p => p.MSPTypeId).IsOptional().HasMaxLength(5);
            Property(p => p.EDICOBLevelId).IsRequired().HasMaxLength(1);
            Property(p => p.UseHCPCSL2).IsRequired();
            Property(p => p.Note).IsOptional().HasColumnType("longtext");
            Property(p => p.Inactive).IsRequired();

            // parents
            HasRequired(p => p.USPSState).WithMany(p => p.InsPlans).HasForeignKey(p => p.USPSStateId).WillCascadeOnDelete(false);
            HasRequired(p => p.IdQualifier).WithMany(p => p.InsPlans).HasForeignKey(p => p.IdQualifierId).WillCascadeOnDelete(false);
            HasRequired(p => p.InsFormType).WithMany(p => p.InsPlans).HasForeignKey(p => p.IdQualifierId).WillCascadeOnDelete(false);
            HasOptional(p => p.InsPlanGroup).WithMany(p => p.InsPlans).HasForeignKey(p => p.InsPlanGroupId).WillCascadeOnDelete(false);
            HasRequired(p => p.ClaimFilingIndicator).WithMany(p => p.InsPlans).HasForeignKey(p => p.ClaimFilingIndicatorId).WillCascadeOnDelete(false);
            HasRequired(p => p.EDICOBLevel).WithMany(p => p.InsPlans).HasForeignKey(p => p.EDICOBLevelId).WillCascadeOnDelete(false);
            HasOptional(p => p.MSPType).WithMany(p => p.InsPlans).HasForeignKey(p => p.MSPTypeId).WillCascadeOnDelete(false);
            HasRequired(p => p.USPSCountry).WithMany(p => p.InsPlans).HasForeignKey(p => p.USPSCountryId).WillCascadeOnDelete(false);

            //// children
            HasMany(c => c.InsPolicies).WithRequired(c => c.InsPlan);
            HasMany(c => c.InsPlanCARActions).WithRequired(c => c.InsPlan);
            HasMany(c => c.InsPlanPhones).WithRequired(c => c.InsPlan);
            HasMany(c => c.PlanProfiles).WithRequired(c => c.InsPlan);
            HasMany(c => c.Claims).WithRequired(c => c.InsPlan);
            HasMany(c => c.PrepRunDetails).WithOptional(c => c.InsPlan);
            HasMany(c => c.TXBatches).WithOptional(c => c.InsPlan);
            HasMany(c => c.TXs).WithOptional(c => c.InsPlan);

        }
    }
}
