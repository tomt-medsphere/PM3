using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class InsCoverageConfiguration : EntityTypeConfiguration<InsCoverage>
    {
        public InsCoverageConfiguration()
        {
            ToTable("InsCoverage");
            HasKey(p => p.InsCoverageId);
            Property(p => p.InsCoverageId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PatientId).IsRequired();
            Property(p => p.InsPolicyId).IsRequired();
            Property(p => p.RelationshipCodeId).IsRequired().HasMaxLength(2);
            Property(p => p.MemberId).IsOptional().HasMaxLength(10);
            Property(p => p.StartDate).IsOptional();
            Property(p => p.EndDate).IsOptional();
            Property(p => p.Note).IsOptional().HasColumnType("text");
            Property(p => p.Sequence).IsRequired();
            Property(p => p.Inactive).IsRequired();

            HasRequired(p => p.InsPolicy).WithMany(p => p.InsCoverages).HasForeignKey(p => p.InsPolicyId).WillCascadeOnDelete(false);
            HasRequired(p => p.Patient).WithMany(p => p.InsCoverages).HasForeignKey(p => p.PatientId).WillCascadeOnDelete(false);
            HasRequired(p => p.RelationshipCode).WithMany(p => p.InsCoverages).HasForeignKey(p => p.RelationshipCodeId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.ChargeInsCoverages).WithRequired(c => c.InsCoverage);
            HasMany(c => c.EDI270s).WithRequired(c => c.InsCoverage);
        }
    }
}
