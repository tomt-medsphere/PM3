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
    public class PrepRunConfiguration : EntityTypeConfiguration<PrepRun>
    {
        public PrepRunConfiguration()
        {
            ToTable("PrepRun");
            HasKey(p => p.PrepRunId);
            Property(p => p.PrepRunId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.RunDateTime).IsRequired();
            Property(p => p.UserId).IsRequired();

            // parents
            HasRequired(p => p.User).WithMany(p => p.PrepRuns).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.Claims).WithRequired(c => c.PrepRun);
            HasMany(c => c.PrepRunDetails).WithRequired(c => c.PrepRun);
        }
    }
}
