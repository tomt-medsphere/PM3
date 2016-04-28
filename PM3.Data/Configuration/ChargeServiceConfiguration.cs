using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ChargeServiceConfiguration : EntityTypeConfiguration<ChargeService>
    {
        public ChargeServiceConfiguration()
        {
            ToTable("ChargeService");
            HasKey(p => p.ChargeServiceId);
            Property(p => p.ChargeServiceId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.PatientId).IsRequired();
            Property(p => p.BillingAccountId).IsRequired();
            Property(p => p.Sequence).IsRequired();
            Property(p => p.DateOfServiceStart).IsRequired();
            Property(p => p.DateOfServiceEnd).IsOptional();
            Property(p => p.ServiceId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.StatementDescription).IsRequired().HasMaxLength(100);
            Property(p => p.HCPCSId).IsOptional().HasMaxLength(10);
            Property(p => p.HCPCSL2Id).IsOptional().HasMaxLength(10);
            Property(p => p.Units).IsRequired();
            Property(p => p.Fee).IsRequired();
            Property(p => p.POSId).IsRequired();
            Property(p => p.BillingNote).IsOptional().HasMaxLength(80);
            Property(p => p.CertificateTypeId).IsOptional().HasMaxLength(10);
            Property(p => p.RenderingProviderId).IsRequired().HasMaxLength(10);
            Property(p => p.SupervisingProviderId).IsOptional().HasMaxLength(10);
            Property(p => p.OrderingProviderId).IsOptional().HasMaxLength(10);
            Property(p => p.AcceptAssignment).IsRequired();
            Property(p => p.PayProvider).IsRequired();
            Property(p => p.BillInsurance).IsRequired();
            Property(p => p.Taxable).IsRequired();
            Property(p => p.NDC).IsOptional().HasMaxLength(20);
            Property(p => p.MEAReferenceId).IsOptional().HasMaxLength(10);
            Property(p => p.MEAQualifierId).IsOptional().HasMaxLength(10);
            Property(p => p.MeasurementUnitId).IsOptional().HasMaxLength(2);
            Property(p => p.MEAValue).IsOptional().HasMaxLength(20);
            Property(p => p.StatementClosed).IsRequired();
            Property(p => p.Balance).IsRequired();
            Property(p => p.StatementBalance).IsRequired();
            Property(p => p.ChargeClosed).IsRequired();
            Property(p => p.ChargeServiceStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.ChargeServiceStatusDate).IsRequired();

            // parents
            HasRequired(p => p.Charge).WithMany(p => p.ChargeServices).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasRequired(p => p.ChargeServiceStatus).WithMany(p => p.ChargeServices).HasForeignKey(p => p.ChargeServiceStatusId).WillCascadeOnDelete(false);
            HasOptional(p => p.MEAQualifier).WithMany(p => p.ChargeServices).HasForeignKey(p => p.MEAQualifierId).WillCascadeOnDelete(false);
            HasOptional(p => p.MEAReference).WithMany(p => p.ChargeServices).HasForeignKey(p => p.MEAReferenceId).WillCascadeOnDelete(false);
            HasOptional(p => p.MeasurementUnit).WithMany(p => p.ChargeServices).HasForeignKey(p => p.MeasurementUnitId).WillCascadeOnDelete(false);
            HasRequired(p => p.Service).WithMany(p => p.ChargeServices).HasForeignKey(p => p.ServiceId).WillCascadeOnDelete(false);
            HasRequired(p => p.Patient).WithMany(p => p.ChargeServices).HasForeignKey(p => p.PatientId).WillCascadeOnDelete(false);
            HasRequired(p => p.BillingAccount).WithMany(p => p.ChargeServices).HasForeignKey(p => p.BillingAccountId).WillCascadeOnDelete(false);
            HasOptional(p => p.HCPCS).WithMany(p => p.HCPCSChargeServices).HasForeignKey(p => p.HCPCSId).WillCascadeOnDelete(false);
            HasOptional(p => p.HCPCSL2).WithMany(p => p.HCPCSL2ChargeServices).HasForeignKey(p => p.HCPCSL2Id).WillCascadeOnDelete(false);
            HasRequired(p => p.POS).WithMany(p => p.ChargeServices).HasForeignKey(p => p.POSId).WillCascadeOnDelete(false);
            HasRequired(p => p.RenderingProvider).WithMany(p => p.RenderingChargeServices).HasForeignKey(p => p.RenderingProviderId).WillCascadeOnDelete(false);
            HasOptional(p => p.SupervisingProvider).WithMany(p => p.SupervisingChargeServices).HasForeignKey(p => p.SupervisingProviderId).WillCascadeOnDelete(false);
            HasOptional(p => p.OrderingProvider).WithMany(p => p.OrderingChargeServices).HasForeignKey(p => p.OrderingProviderId).WillCascadeOnDelete(false);
            HasOptional(p => p.CertificateType).WithMany(p => p.ChargeServices).HasForeignKey(p => p.CertificateTypeId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.ChargeServiceMods).WithRequired(c => c.ChargeService);
            HasMany(c => c.ChargeServiceICDs).WithRequired(c => c.ChargeService);
            HasMany(c => c.PrepErrors).WithOptional(c => c.ChargeService);
            HasMany(c => c.PrepRunPrepErrors).WithOptional(c => c.ChargeService);
            HasMany(c => c.TXs).WithRequired(c => c.ChargeService);
            HasMany(c => c.EDI277STCs).WithOptional(c => c.ChargeService);
        }
    }
}
