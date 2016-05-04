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
    public class PlanProfileDetailConfiguration : EntityTypeConfiguration<PlanProfileDetail>
    {
        public PlanProfileDetailConfiguration()
        {
            ToTable("PlanProfileDetail");
            HasKey(p => p.PlanProfileDetailId);
            Property(p => p.PlanProfileDetailId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PlanProfileId).IsRequired();
            Property(p => p.HCPCSId).IsRequired().HasMaxLength(5);
            Property(p => p.HCPCSModifierId).IsOptional().HasMaxLength(2);
            Property(p => p.Fee).IsOptional().HasPrecision(18, 2);
            Property(p => p.Allowed).IsOptional().HasPrecision(18, 2);
            Property(p => p.ChargeNote).IsOptional().HasMaxLength(255);
            Property(p => p.TXNote).IsOptional().HasMaxLength(255);
            Property(p => p.NPI).IsOptional().HasMaxLength(10);

            // parents
            HasRequired(p => p.PlanProfile).WithMany(p => p.PlanProfileDetails).HasForeignKey(p => p.PlanProfileId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.PlanProfileEvents).WithRequired(c => c.PlanProfileDetail);
        }
    }
}
