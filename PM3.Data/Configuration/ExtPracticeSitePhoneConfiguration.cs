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
    public class ExtPracticeSitePhoneConfiguration : EntityTypeConfiguration<ExtPracticeSitePhone>
    {
        public ExtPracticeSitePhoneConfiguration()
        {
            ToTable("ExtPracticeSitePhone");
            HasKey(p => p.ExtPracticeSitePhoneId);
            Property(p => p.ExtPracticeSitePhoneId).IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ExtPracticeSiteId).IsRequired();
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.ExtPracticeSite).WithMany(p => p.ExtPracticeSitePhones);
            HasRequired(p => p.Phone).WithMany(p => p.ExtPracticeSitePhones);

        }
    }
}
