using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class EDI277Configuration : EntityTypeConfiguration<EDI277>
    {
        public EDI277Configuration()
        {
            ToTable("EDI277");
            HasKey(p => p.EDI277Id);
            Property(p => p.EDI277Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ClaimRunId).IsOptional();
            Property(p => p.EDI277Text).IsRequired();
            Property(p => p.SourceId).IsOptional().HasMaxLength(30);
            Property(p => p.SourceName).IsOptional().HasMaxLength(60);
            Property(p => p.SourceProcessDate).IsOptional();

            // parents
            HasOptional(p => p.ClaimRun).WithMany(p => p.EDI277s).HasForeignKey(p => p.ClaimRunId).WillCascadeOnDelete(false);
            
            // children
            HasMany(c => c.EDI277STCs).WithRequired(c => c.EDI277);
        }
    }
}
