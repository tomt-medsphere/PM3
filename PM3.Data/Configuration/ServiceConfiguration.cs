using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ServiceConfiguration : EntityTypeConfiguration<Service>
    {
        public ServiceConfiguration()
        {
            ToTable("Service");
            HasKey(p => p.ServiceId);
            Property(p => p.ServiceId).IsRequired().HasMaxLength(10);
            Property(p => p.ServiceCategoryId).IsOptional().HasMaxLength(10);
            Property(p => p.HCPCSId).IsOptional().HasMaxLength(10);
            Property(p => p.HCPCSL2Id).IsOptional().HasMaxLength(10);
            Property(p => p.RevenueCodeId).IsOptional().HasMaxLength(10);
            Property(p => p.NDC).IsOptional().HasMaxLength(20);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.StatementDescription).IsRequired().HasMaxLength(100);
            Property(p => p.StandardFee).IsRequired().HasPrecision(18, 2);
            Property(p => p.Taxable).IsRequired();
            Property(p => p.Units).IsRequired().HasPrecision(18, 4);
            Property(p => p.MeasurementUnitId).IsOptional().HasMaxLength(2);
            Property(p => p.POSId).IsOptional().HasMaxLength(10);
            Property(p => p.TOSId).IsRequired().HasMaxLength(5);
            Property(p => p.PracticeNote).IsOptional().HasColumnType("text");
            Property(p => p.BillingNote).IsOptional().HasMaxLength(80);
            Property(p => p.NOCNote).IsOptional().HasMaxLength(80);
            Property(p => p.FlashNote).IsRequired();
            Property(p => p.CertficateTypeId).IsOptional().HasMaxLength(10);
            Property(p => p.RequireOrdering).IsOptional();
            Property(p => p.RequireReferring).IsOptional();
            Property(p => p.Inactive).IsRequired();

            // parents
            HasOptional(p => p.ServiceCategory).WithMany(p => p.Services).HasForeignKey(p => p.ServiceCategoryId).WillCascadeOnDelete(false);
            HasOptional(p => p.HCPCS).WithMany(p => p.HCPCSServices).HasForeignKey(p => p.HCPCSId).WillCascadeOnDelete(false);
            HasOptional(p => p.HCPCSL2).WithMany(p => p.HCPCSL2Services).HasForeignKey(p => p.HCPCSL2Id).WillCascadeOnDelete(false);
            HasOptional(p => p.RevenueCode).WithMany(p => p.Services).HasForeignKey(p => p.RevenueCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.POS).WithMany(p => p.Services).HasForeignKey(p => p.POSId).WillCascadeOnDelete(false);
            HasRequired(p => p.TOS).WithMany(p => p.Services).HasForeignKey(p => p.TOSId).WillCascadeOnDelete(false);
            HasOptional(p => p.CertificateType).WithMany(p => p.Services).HasForeignKey(p => p.CertficateTypeId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.ServiceHCPCSModifiers).WithRequired(c => c.Service);
            HasMany(c => c.ChargeServices).WithRequired(c => c.Service);
            HasMany(c => c.ServiceMacroDetails).WithRequired(c => c.Service);
        }
    }
}
