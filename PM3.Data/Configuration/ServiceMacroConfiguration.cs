using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ServiceMacroConfiguration : EntityTypeConfiguration<ServiceMacro>
    {
        public ServiceMacroConfiguration()
        {
            ToTable("ServiceMacro");
            HasKey(p => p.ServiceMacroId);
            Property(p => p.ServiceMacroId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsOptional().HasMaxLength(100);
            Property(p => p.Inactive).IsRequired();

            // children
            HasMany(c => c.ServiceMacroDetails).WithRequired(c => c.ServiceMacro);
        }
    }
}
