using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class HCPCSModifierConfiguration : EntityTypeConfiguration<HCPCSModifier>
    {
        public HCPCSModifierConfiguration()
        {
            ToTable("HCPCSModifier");
            HasKey(p => p.HCPCSModifierId);
            Property(p => p.HCPCSModifierId).IsRequired().HasMaxLength(2);
            Property(p => p.Description).IsRequired();
            Property(p => p.StartDate).IsRequired();
            Property(p => p.EndDate).IsOptional();

            // children
            HasMany(c => c.TXHCPCSModifiers).WithRequired(c => c.HCPCSModifier);
            HasMany(c => c.ServiceHCPCSModifiers).WithRequired(c => c.HCPCSModifier);
            HasMany(c => c.ChargeServiceMods).WithRequired(c => c.HCPCSModifier);
        }
    }
}
