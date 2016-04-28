using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class CMSSpecialityConfiguration : EntityTypeConfiguration<CMSSpeciality>
    {
        public CMSSpecialityConfiguration()
        {
            ToTable("CMSSpeciality");
            HasKey(p => p.CMSSpecialityId);
            Property(p => p.CMSSpecialityId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.ExtProviders).WithOptional(c => c.CMSSpeciality);
            HasMany(c => c.TaxomonyCodes).WithRequired(c => c.CMSSpeciality);
        }
    }
}
