using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class LanguageConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            ToTable("Language");
            HasKey(p => p.LanguageId);
            Property(p => p.LanguageId).IsRequired().HasMaxLength(3);
            Property(p => p.Description).IsRequired().HasMaxLength(255);

            // children
            HasMany(c => c.Persons).WithOptional(c => c.Language);
        }
    }
}
