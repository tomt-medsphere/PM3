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
    public class EDI270Configuration : EntityTypeConfiguration<EDI270>
    {
        public EDI270Configuration()
        {
            ToTable("EDI270");
            HasKey(p => p.EDI270Id);
            Property(p => p.EDI270Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.InsCoverageId).IsRequired();
            Property(p => p.ProviderId).IsRequired().HasMaxLength(10);
            Property(p => p.TOSId).IsRequired().HasMaxLength(10);
            Property(p => p.RequestDateOfService).IsRequired();
            Property(p => p.CoverageActive).IsRequired();
            Property(p => p.InquiryDateTime).IsRequired();
            Property(p => p.EDI270Txt).IsRequired();
            Property(p => p.InquiryStatus).IsOptional().HasMaxLength(30);
            Property(p => p.EDI271Txt).IsOptional();
            Property(p => p.CoverageStartDate).IsOptional();
            Property(p => p.CoverageEndDate).IsOptional();
            Property(p => p.UserId).IsRequired().HasMaxLength(255);

            // parents
            HasRequired(p => p.User).WithMany(p => p.EDI270s).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.Provider).WithMany(p => p.EDI270s).HasForeignKey(p => p.ProviderId).WillCascadeOnDelete(false);
            HasRequired(p => p.InsCoverage).WithMany(p => p.EDI270s).HasForeignKey(p => p.InsCoverageId).WillCascadeOnDelete(false);
            HasRequired(p => p.TOS).WithMany(p => p.EDI270s).HasForeignKey(p => p.TOSId).WillCascadeOnDelete(false);
        }
    }
}
