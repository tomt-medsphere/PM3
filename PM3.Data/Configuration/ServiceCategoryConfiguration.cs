using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ServiceCategoryConfiguration : EntityTypeConfiguration<ServiceCategory>
    {
        public ServiceCategoryConfiguration()
        {
            ToTable("ServiceCategory");
            HasKey(p => p.ServiceCategoryId);
            Property(p => p.ServiceCategoryId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.Inactive).IsRequired();

            // children
            HasMany(c => c.Services).WithOptional(c => c.ServiceCategory);
        }
    }
}
