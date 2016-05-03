using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PhoneTypeConfiguration : EntityTypeConfiguration<PhoneType>
    {
        public PhoneTypeConfiguration()
        {
            ToTable("PhoneType");
            HasKey(p => p.PhoneTypeId);
            Property(p => p.PhoneTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Phones).WithRequired(c => c.PhoneType);
        }
    }
}
