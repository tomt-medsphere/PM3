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
    public class TXCASConfiguration : EntityTypeConfiguration<TXCAS>
    {
        public TXCASConfiguration()
        {
            ToTable("TXCAS");
            HasKey(p => p.TXCASId);
            Property(p => p.TXCASId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TXId).IsRequired();
            Property(p => p.CAGCodeId).IsRequired().HasMaxLength(2);
            Property(p => p.CARCodeId).IsRequired().HasMaxLength(5);
            Property(p => p.Amount).IsRequired().HasPrecision(18, 2);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.TX).WithMany(p => p.TXCASs).HasForeignKey(p => p.TXId).WillCascadeOnDelete(false);
            HasRequired(p => p.CAGCode).WithMany(p => p.TXCASs).HasForeignKey(p => p.CAGCodeId).WillCascadeOnDelete(false);
            HasRequired(p => p.CARCode).WithMany(p => p.TXCASs).HasForeignKey(p => p.CARCodeId).WillCascadeOnDelete(false);
        }
    }
}
