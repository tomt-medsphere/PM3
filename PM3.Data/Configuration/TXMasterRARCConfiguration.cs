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
    public class TXMasterRARCConfiguration : EntityTypeConfiguration<TXMasterRARC>
    {
        public TXMasterRARCConfiguration()
        {
            ToTable("TXMasterRARC");
            HasKey(p => p.TXMasterRARCid);
            Property(p => p.TXMasterRARCid).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TXMasterId).IsRequired();
            Property(p => p.RARCId).IsRequired().HasMaxLength(10);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.TXMaster).WithMany(p => p.TXMasterRARC).HasForeignKey(p => p.TXMasterId).WillCascadeOnDelete(false);
            HasRequired(p => p.RARC).WithMany(p => p.TXMasterRARCs).HasForeignKey(p => p.RARCId).WillCascadeOnDelete(false);
        }
    }
}
