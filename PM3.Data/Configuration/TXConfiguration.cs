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
    public class TXConfiguration : EntityTypeConfiguration<TX>
    {
        public TXConfiguration()
        {
            ToTable("TX");
            HasKey(p => p.TXId);
            Property(p => p.TXId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TXMasterId).IsRequired();
            Property(p => p.ProviderId).IsRequired().HasMaxLength(10);
            Property(p => p.ChargeServiceId).IsRequired();
            Property(p => p.ChargeInsCoverageId).IsOptional();
            Property(p => p.InsPlanId).IsOptional().HasMaxLength(10);
            Property(p => p.TxCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.PaymentFormId).IsRequired().HasMaxLength(10);
            Property(p => p.Amount).IsRequired().HasPrecision(18, 2);
            Property(p => p.Allowed).IsOptional().HasPrecision(18, 2);
            Property(p => p.HCPCSId).IsOptional().HasMaxLength(10);
            Property(p => p.Units).IsRequired().HasPrecision(18, 4);
            Property(p => p.Note).IsOptional().HasColumnType("text");
            Property(p => p.ICN).IsOptional().HasMaxLength(30);
            Property(p => p.TXClosed).IsRequired();
            Property(p => p.CAGCodeId).IsOptional().HasMaxLength(2);
            Property(p => p.CARCodeId).IsOptional().HasMaxLength(5);
            Property(p => p.EntryDateTime).IsRequired();
            Property(p => p.UserId).IsRequired().HasMaxLength(255);

            // parents
            HasRequired(p => p.TXMaster).WithMany(p => p.TXs).HasForeignKey(p => p.TXMasterId).WillCascadeOnDelete(false);
            HasRequired(p => p.ChargeService).WithMany(p => p.TXs).HasForeignKey(p => p.ChargeServiceId).WillCascadeOnDelete(false);
            HasRequired(p => p.TxCode).WithMany(p => p.TXs).HasForeignKey(p => p.TxCodeId).WillCascadeOnDelete(false);
            HasRequired(p => p.PaymentForm).WithMany(p => p.TXs).HasForeignKey(p => p.PaymentFormId).WillCascadeOnDelete(false);
            HasRequired(p => p.User).WithMany(p => p.TXs).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.Provider).WithMany(p => p.TXs).HasForeignKey(p => p.ProviderId).WillCascadeOnDelete(false);
            HasOptional(p => p.InsPlan).WithMany(p => p.TXs).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
            HasOptional(p => p.CARCode).WithMany(p => p.TXs).HasForeignKey(p => p.CARCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.CAGCode).WithMany(p => p.TXs).HasForeignKey(p => p.CAGCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.ChargeInsCoverage).WithMany(p => p.TXs).HasForeignKey(p => p.ChargeInsCoverageId).WillCascadeOnDelete(false);
            HasOptional(p => p.HCPCS).WithMany(p => p.TXs).HasForeignKey(p => p.HCPCSId).WillCascadeOnDelete(false);
            
            // children
            HasMany(c => c.TXHCPCSModifiers).WithRequired(c => c.TX);
            HasMany(c => c.TXCASs).WithRequired(c => c.TX);
        }
    }
}
