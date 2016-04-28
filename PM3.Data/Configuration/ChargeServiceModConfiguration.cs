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
    public class ChargeServiceModConfiguration : EntityTypeConfiguration<ChargeServiceMod>
    {
        public ChargeServiceModConfiguration()
        {
            ToTable("ChargeServiceMod");
            HasKey(p => p.ChargeServiceModId);
            Property(p => p.ChargeServiceModId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeServiceId).IsRequired();
            Property(p => p.HCPCSModifierId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.ChargeService).WithMany(p => p.ChargeServiceMods).HasForeignKey(p => p.ChargeServiceId).WillCascadeOnDelete(false);
            HasRequired(p => p.HCPCSModifier).WithMany(p => p.ChargeServiceMods).HasForeignKey(p => p.HCPCSModifierId).WillCascadeOnDelete(false);
        }
    }
}
