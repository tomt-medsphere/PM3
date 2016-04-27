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
    public class ChargeConfiguration : EntityTypeConfiguration<Charge>
    {
        public ChargeConfiguration()
        {
            ToTable("Charge");
            HasKey(p => p.ChargeId);
            Property(p => p.ChargeId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PatientId).IsRequired();
            Property(p => p.BillingAccountId).IsRequired();
            Property(p => p.PracticeSiteId).IsRequired().HasMaxLength(10);
            Property(p => p.FacilityAdmissionId).IsOptional();
            Property(p => p.ExtFacilityId).IsOptional().HasMaxLength(10);
            Property(p => p.AdmitDateTime).IsOptional();
            Property(p => p.DischargeDateTime).IsOptional();
            Property(p => p.PWKTransmissionCodeId).IsOptional().HasMaxLength(10);
            Property(p => p.PWKTypeCodeId).IsOptional().HasMaxLength(10);
            Property(p => p.PaperworkId).IsOptional().HasMaxLength(60);
            Property(p => p.RefProviderId).IsOptional().HasMaxLength(10);
            Property(p => p.ReferralDate).IsOptional();
            Property(p => p.PCPId).IsOptional().HasMaxLength(10);
            Property(p => p.PCPLastSeen).IsOptional();
            Property(p => p.NatureOfConditionId).IsOptional().HasMaxLength(10);
            Property(p => p.LastXRay).IsOptional();
            Property(p => p.Emergency).IsRequired();
            Property(p => p.WorkRelated).IsRequired();
            Property(p => p.DateOfInjury).IsOptional();
            Property(p => p.InitialTreatmentDate).IsOptional();
            Property(p => p.DateOfOnset).IsOptional();
            Property(p => p.SameSimilarSysympton).IsOptional();
            Property(p => p.AcuteManifestation).IsOptional();
            Property(p => p.DisabilityType).IsOptional().HasMaxLength(10);
            Property(p => p.DisabilityStart).IsOptional();
            Property(p => p.DisabilityEnd).IsOptional();
            Property(p => p.LastWorked).IsOptional();
            Property(p => p.ReturnToWork).IsOptional();
            Property(p => p.AccidentCodeId).IsOptional().HasMaxLength(2);
            Property(p => p.AccidentDateTime).IsOptional();
            Property(p => p.CLIATypeId).IsOptional().HasMaxLength(10);
            Property(p => p.CLIANumber).IsOptional().HasMaxLength(10);
            Property(p => p.MammographyCert).IsOptional().HasMaxLength(50);
            Property(p => p.PriorAuthCode).IsOptional().HasMaxLength(50);
            Property(p => p.Pregnant).IsRequired();
            Property(p => p.LMP).IsOptional();
            Property(p => p.EDC).IsOptional();
            Property(p => p.EPSDTCodeId).IsOptional().HasMaxLength(10);
            Property(p => p.ChargeBatchId).IsOptional();
            Property(p => p.ChargeClosed).IsRequired();
            Property(p => p.ForceToPaper).IsOptional();
            Property(p => p.EntryDateTime).IsRequired();
            Property(p => p.UserId).IsOptional().HasMaxLength(255);
            Property(p => p.ChargePrepped).IsRequired();
            Property(p => p.CurrentPayerCoverageId).IsOptional();

            // parents
            HasOptional(p => p.EPSDTCode).WithMany(p => p.Charges).HasForeignKey(p => p.EPSDTCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.RefProvider).WithMany(p => p.RefCharges).HasForeignKey(p => p.RefProviderId).WillCascadeOnDelete(false);
            HasOptional(p => p.PCP).WithMany(p => p.PCPCharges).HasForeignKey(p => p.PCPId).WillCascadeOnDelete(false);
            HasRequired(p => p.PracticeSite).WithMany(p => p.Charges).HasForeignKey(p => p.PracticeSiteId).WillCascadeOnDelete(false);
            HasRequired(p => p.Patient).WithMany(p => p.Charges).HasForeignKey(p => p.PatientId).WillCascadeOnDelete(false);
            HasRequired(p => p.BillingAccount).WithMany(p => p.Charges).HasForeignKey(p => p.BillingAccountId).WillCascadeOnDelete(false);
            HasOptional(p => p.AccidentState).WithMany(p => p.Charges).HasForeignKey(p => p.AccidentStateId).WillCascadeOnDelete(false);
            HasOptional(p => p.NatureOfCondition).WithMany(p => p.Charges).HasForeignKey(p => p.NatureOfConditionId).WillCascadeOnDelete(false);
            HasRequired(p => p.User).WithMany(p => p.Charges).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);

        }
    }
}
