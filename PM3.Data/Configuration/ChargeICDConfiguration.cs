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
    public class ChargeICDConfiguration : EntityTypeConfiguration<ChargeICD>
    {
        public ChargeICDConfiguration()
        {
            ToTable("ChargeICD");
            HasKey(p => p.ChargeICDId);
            Property(p => p.ChargeICDId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.ICDId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.Charge).WithMany(p => p.ChargeICDs).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasRequired(p => p.ICD).WithMany(p => p.ChargeICDs).HasForeignKey(p => p.ICDId).WillCascadeOnDelete(false);
        }
    }
}
