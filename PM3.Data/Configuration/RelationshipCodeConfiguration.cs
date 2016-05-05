using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class RelationshipCodeConfiguration : EntityTypeConfiguration<RelationshipCode>
    {
        public RelationshipCodeConfiguration()
        {
            ToTable("RelationshipCode");
            HasKey(p => p.RelationshipCodeId);
            Property(p => p.RelationshipCodeId).IsRequired().HasMaxLength(2);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.PatientBillingAccounts).WithRequired(c => c.RelationshipCode);
            HasMany(c => c.InsCoverages).WithRequired(c => c.RelationshipCode);
            HasMany(c => c.GuardianPersons).WithOptional(c => c.GuardianRelationship);
            HasMany(c => c.EmergencyContactPersons).WithOptional(c => c.EmergencycontactRelationship);
        }
    }
}