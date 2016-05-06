using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class USPSCountryConfiguration : EntityTypeConfiguration<USPSCountry>
    {
        public USPSCountryConfiguration()
        {
            ToTable("USPSCountry");
            HasKey(p => p.USPSCountryId);
            Property(p => p.USPSCountryId).IsRequired().HasMaxLength(2);
            Property(p => p.Name).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Persons).WithOptional(c => c.USPSCountry);
            HasMany(c => c.Employers).WithOptional(c => c.USPSCountry);
            HasMany(c => c.ExtFacilities).WithOptional(c => c.USPSCountry);
            HasMany(c => c.InsPlans).WithRequired(c => c.USPSCountry);
            HasMany(c => c.ExtPracticeSites).WithOptional(c => c.USPSCountry);
            HasMany(c => c.Practices).WithRequired(c => c.USPSCountry);
            HasMany(c => c.RemitPractices).WithRequired(c => c.RemitUSPSCountry);
        }
    }
}
