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
    public class EDI835LogConfiguration : EntityTypeConfiguration<EDI835Log>
    {
        public EDI835LogConfiguration()
        {
            ToTable("EDI835Log");
            HasKey(p => p.EDI835LogId);
            Property(p => p.EDI835LogId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EDI835Id).IsRequired();
            Property(p => p.MessageDateTime).IsRequired();
            Property(p => p.Message).IsRequired();

            // parents
            HasRequired(p => p.EDI835).WithMany(p => p.EDI835Log).HasForeignKey(p => p.EDI835Id).WillCascadeOnDelete(false);
        }
    }
}
