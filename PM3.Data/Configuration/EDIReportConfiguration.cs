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
    public class EDIReportConfiguration : EntityTypeConfiguration<EDIReport>
    {
        public EDIReportConfiguration()
        {
            ToTable("EDIReport");
            HasKey(p => p.EDIReportId);
            Property(p => p.EDIReportId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EDIInboxId).IsOptional();
            Property(p => p.SenderId).IsOptional().HasMaxLength(60);
            Property(p => p.ReceiverId).IsOptional().HasMaxLength(60);
            Property(p => p.ReceivedDateTime).IsRequired();
            Property(p => p.Archived).IsRequired();
            Property(p => p.Description).IsOptional().HasMaxLength(100);
            Property(p => p.ReportId).IsOptional().HasMaxLength(60);
            Property(p => p.ReportText).IsOptional();

            // parents
            HasOptional(p => p.EDIInbox).WithMany(p => p.EDIReports).HasForeignKey(p => p.EDIInboxId).WillCascadeOnDelete(false);

        }
    }
}
