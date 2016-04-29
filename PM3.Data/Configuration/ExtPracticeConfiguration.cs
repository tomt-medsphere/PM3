using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ExtPracticeConfiguration : EntityTypeConfiguration<ExtPractice>
    {
        public ExtPracticeConfiguration()
        {
            ToTable("ExtPractice");
            HasKey(p => p.ExtPracticeId);
            Property(p => p.ExtPracticeId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Inactive).IsRequired();

            // children
            HasMany(c => c.ExtPracticeSites).WithRequired(c => c.ExtPractice);
            HasMany(c => c.ExtProviders).WithOptional(c => c.ExtPractice);
        }
    }
}
