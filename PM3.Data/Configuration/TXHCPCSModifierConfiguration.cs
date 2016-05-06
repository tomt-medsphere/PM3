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
    public class TXHCPCSModifierConfiguration : EntityTypeConfiguration<TXHCPCSModifier>
    {
        public TXHCPCSModifierConfiguration()
        {
            ToTable("TXHCPCSModifier");
            HasKey(p => p.TXHCPCSModifierId);
            Property(p => p.TXHCPCSModifierId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TXId).IsRequired();
            Property(p => p.HCPCSModifierId).IsRequired().HasMaxLength(2);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.TX).WithMany(p => p.TXHCPCSModifiers).HasForeignKey(p => p.TXId).WillCascadeOnDelete(false);
            HasRequired(p => p.HCPCSModifier).WithMany(p => p.TXHCPCSModifiers).HasForeignKey(p => p.HCPCSModifierId).WillCascadeOnDelete(false);
        }
    }
}
