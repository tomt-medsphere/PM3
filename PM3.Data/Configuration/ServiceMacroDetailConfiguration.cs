using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ServiceMacroDetailConfiguration : EntityTypeConfiguration<ServiceMacroDetail>
    {
        public ServiceMacroDetailConfiguration()
        {
            ToTable("ServiceMacroDetail");
            HasKey(p => new {p.ServiceMacroId, p.ServiceId});
            Property(p => p.ServiceMacroId).IsRequired().HasMaxLength(10);
            Property(p => p.ServiceId).IsRequired().HasMaxLength(10);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.ServiceMacro).WithMany(p => p.ServiceMacroDetails).HasForeignKey(p => p.ServiceMacroId).WillCascadeOnDelete(false);
            HasRequired(p => p.Service).WithMany(p => p.ServiceMacroDetails).HasForeignKey(p => p.ServiceId).WillCascadeOnDelete(false);
        }
    }
}
