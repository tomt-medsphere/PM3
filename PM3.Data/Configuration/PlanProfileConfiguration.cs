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
    public class PlanProfileConfiguration : EntityTypeConfiguration<PlanProfile>
    {
        public PlanProfileConfiguration()
        {
            ToTable("PlanProfile");
            HasKey(p => p.PlanProfileId);
            Property(p => p.PlanProfileId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.InsPlanId).IsOptional().HasMaxLength(10);
            Property(p => p.InsPlanGroupId).IsOptional().HasMaxLength(10);
            Property(p => p.DOSStart).IsRequired();
            Property(p => p.DOSEnd).IsOptional();
            Property(p => p.AutoUpdate).IsRequired().HasMaxLength(10);
            Property(p => p.EventAction).IsRequired().HasMaxLength(10);
            Property(p => p.OverrideFees).IsRequired();
            Property(p => p.Description).IsOptional().HasColumnType("text");
            Property(p => p.NPITracking).IsRequired();
            Property(p => p.Inactive).IsRequired();

            // parents
            HasOptional(p => p.InsPlan).WithMany(p => p.PlanProfiles).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
            HasOptional(p => p.InsPlanGroup).WithMany(p => p.PlanProfiles).HasForeignKey(p => p.InsPlanGroupId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.PlanProfileDetails).WithRequired(c => c.PlanProfile);
        }
    }
}
