using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class SuffixConfiguration : EntityTypeConfiguration<Suffix>
    {
        public SuffixConfiguration()
        {
            ToTable("Suffix");
            HasKey(p => p.SuffixId);
            Property(p => p.SuffixId).IsRequired().HasMaxLength(10);

            // children
            HasMany(c => c.Persons).WithOptional(c => c.Suffix);
            HasMany(c => c.ExtProviders).WithOptional(c => c.Suffix);
            HasMany(c => c.Providers).WithOptional(c => c.Suffix);
            HasMany(c => c.Users).WithOptional(c => c.Suffix);
        }
    }
}
