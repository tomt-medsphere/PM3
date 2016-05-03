using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PatientBillingAccountConfiguration : EntityTypeConfiguration<PatientBillingAccount>
    {
        public PatientBillingAccountConfiguration()
        {
            ToTable("PatientBillingAccount");
            HasKey(p => p.PatientBillingAccountId);
            Property(p => p.PatientBillingAccountId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PatientId).IsRequired();
            Property(p => p.BillingAccountId).IsRequired();
            Property(p => p.RelationshipCodeId).IsOptional().HasMaxLength(2);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.BillingAccount).WithMany(p => p.PatientBillingAccounts).HasForeignKey(p => p.BillingAccountId).WillCascadeOnDelete(false);
            HasRequired(p => p.Patient).WithMany(p => p.PatientBillingAccounts).HasForeignKey(p => p.PatientId).WillCascadeOnDelete(false);
            HasOptional(p => p.RelationshipCode).WithMany(p => p.PatientBillingAccounts).HasForeignKey(p => p.RelationshipCodeId).WillCascadeOnDelete(false);

        }
    }
}
