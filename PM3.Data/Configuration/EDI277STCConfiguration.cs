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
    public class EDI277STCConfiguration : EntityTypeConfiguration<EDI277STC>
    {
        public EDI277STCConfiguration()
        {
            ToTable("EDI277STC");
            HasKey(p => p.EDI277STCId);
            Property(p => p.EDI277STCId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EDI277Id).IsRequired();
            Property(p => p.ClaimId).IsRequired();
            Property(p => p.ChargeId).IsOptional();
            Property(p => p.ChargeServiceId).IsOptional();
            Property(p => p.STCSegment).IsRequired();
            Property(p => p.REF1K).IsOptional().HasMaxLength(50);

            // parents
            HasRequired(p => p.EDI277).WithMany(p => p.EDI277STCs).HasForeignKey(p => p.EDI277Id).WillCascadeOnDelete(false);
            HasRequired(p => p.Claim).WithMany(p => p.EDI277STCs).HasForeignKey(p => p.ClaimId).WillCascadeOnDelete(false);
            HasOptional(p => p.Charge).WithMany(p => p.EDI277STCs).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasOptional(p => p.ChargeService).WithMany(p => p.EDI277STCs).HasForeignKey(p => p.ChargeServiceId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.EDI277STCActions).WithRequired(c => c.EDI277STC);

        }
    }
}
