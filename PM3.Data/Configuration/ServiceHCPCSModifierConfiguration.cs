using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ServiceHCPCSModifierConfiguration : EntityTypeConfiguration<ServiceHCPCSModifier>
    {
        public ServiceHCPCSModifierConfiguration()
        {
            ToTable("ServiceHCPCSModifier");
            HasKey(p => new {p.ServiceId, p.HCPCSModifierId});
            Property(p => p.ServiceId).IsRequired().HasMaxLength(10);
            Property(p => p.HCPCSModifierId).IsRequired().HasMaxLength(2);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.Service).WithMany(p => p.ServiceHCPCSModifiers).HasForeignKey(p => p.ServiceId).WillCascadeOnDelete(false);
            HasRequired(p => p.HCPCSModifier).WithMany(p => p.ServiceHCPCSModifiers).HasForeignKey(p => p.HCPCSModifierId).WillCascadeOnDelete(false);
        }
    }
}
