using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ITUCountryConfiguration : EntityTypeConfiguration<ITUCountry>
    {
        public ITUCountryConfiguration()
        {
            ToTable("ITUCountry");
            HasKey(p => p.ITUCountryId);
            Property(p => p.ITUCountryId).IsRequired().HasMaxLength(5);
            Property(p => p.Name).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Phones).WithRequired(c => c.ITUCountry);
        }
    }
}
