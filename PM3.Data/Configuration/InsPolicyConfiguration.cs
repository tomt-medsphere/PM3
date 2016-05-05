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
    public class InsPolicyConfiguration : EntityTypeConfiguration<InsPolicy>
    {
        public InsPolicyConfiguration()
        {
            ToTable("InsPolicy");
            HasKey(p => p.InsPolicyId);
            Property(p => p.InsPolicyId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.InsPlanId).IsRequired().HasMaxLength(10);
            Property(p => p.SubscriberId).IsRequired();
            Property(p => p.PolicyNumber).IsRequired().HasMaxLength(80);
            Property(p => p.GroupNumber).IsOptional().HasMaxLength(50);
            Property(p => p.GroupName).IsOptional().HasMaxLength(60);
            Property(p => p.StartDate).IsOptional();
            Property(p => p.EndDate).IsOptional();
            Property(p => p.Note).IsOptional().HasColumnType("text");
            Property(p => p.CoPayAmount).IsOptional();
            Property(p => p.SubscriberMemberId).IsOptional().HasMaxLength(10);
            Property(p => p.DateOfInjury).IsOptional();
            Property(p => p.AccidentCodeId).IsOptional().HasMaxLength(10);
            Property(p => p.AccidentStateId).IsOptional().HasMaxLength(2);
            Property(p => p.AltSubLastName).IsOptional().HasMaxLength(60);
            Property(p => p.AltSubFirstName).IsOptional().HasMaxLength(35);
            Property(p => p.AltSubMiddleName).IsOptional().HasMaxLength(25);
            Property(p => p.AltSubSuffixId).IsOptional().HasMaxLength(10);
            Property(p => p.AltSubDOB).IsOptional();

            // parents
            HasRequired(p => p.InsPlan).WithMany(p => p.InsPolicies).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
            HasRequired(p => p.Subscriber).WithMany(p => p.InsPolcies).HasForeignKey(p => p.SubscriberId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.InsCoverages).WithRequired(c => c.InsPolicy);
            HasMany(c => c.InsPolicyAllowedDXs).WithRequired(c => c.InsPolicy);
        }
    }
}
