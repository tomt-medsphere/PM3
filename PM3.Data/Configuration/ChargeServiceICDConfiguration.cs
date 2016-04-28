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
    public class ChargeServiceICDConfiguration : EntityTypeConfiguration<ChargeServiceICD>
    {
        public ChargeServiceICDConfiguration()
        {
            ToTable("ChargeServiceICD");
            HasKey(p => p.ChargeServiceICDId);
            Property(p => p.ChargeServiceICDId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeServiceId).IsRequired();
            Property(p => p.ICDId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.ChargeService).WithMany(p => p.ChargeServiceICDs).HasForeignKey(p => p.ChargeServiceId).WillCascadeOnDelete(false);
            HasRequired(p => p.ICD).WithMany(p => p.ChargeServiceICDs).HasForeignKey(p => p.ICDId).WillCascadeOnDelete(false);
        }
    }
}
