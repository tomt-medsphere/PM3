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
            HasRequired(p => p.Charge).WithMany(p => p.ChargeServices);
            HasRequired(p => p.ChargeServiceStatus).WithMany(p => p.ChargeServices);
            HasOptional(p => p.MEAQualifier).WithMany(p => p.ChargeServices);

        }
    }
}
