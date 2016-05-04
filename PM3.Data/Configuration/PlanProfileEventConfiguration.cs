using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PlanProfileEventConfiguration : EntityTypeConfiguration<PlanProfileEvent>
    {
        public PlanProfileEventConfiguration()
        {
            ToTable("PlanProfileEvent");
            HasKey(p => p.PlanProfileEventId);
            Property(p => p.PlanProfileEventId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PlanProfileDetailId).IsRequired();
            Property(p => p.TXId).IsRequired();
            Property(p => p.EventDateTime).IsRequired();
            Property(p => p.Type).IsRequired().HasMaxLength(10);
            Property(p => p.Note).IsOptional().HasMaxLength(255);
            Property(p => p.UserId).IsRequired().HasMaxLength(255);
            Property(p => p.EventReasonCode).IsOptional().HasMaxLength(10);
            Property(p => p.EventAction).IsOptional().HasMaxLength(10);
            Property(p => p.HCPCSId).IsRequired().HasMaxLength(5);
            Property(p => p.HCPCSModifierId).IsOptional().HasMaxLength(2);

            // parents
            HasRequired(p => p.PlanProfileDetail).WithMany(p => p.PlanProfileEvents).HasForeignKey(p => p.PlanProfileDetailId).WillCascadeOnDelete(false);
            HasRequired(p => p.HCPCS).WithMany(p => p.PlanProfileEvents).HasForeignKey(p => p.HCPCSId).WillCascadeOnDelete(false);
            HasOptional(p => p.HCPCSModifier).WithMany(p => p.PlanProfileEvents).HasForeignKey(p => p.HCPCSModifierId).WillCascadeOnDelete(false);
        }
    }
}
