using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PracticeSitePhoneConfiguration : EntityTypeConfiguration<PracticeSitePhone>
    {
        public PracticeSitePhoneConfiguration()
        {
            ToTable("PracticeSitePhone");
            HasKey(p => p.PracticeSitePhoneId);
            Property(p => p.PracticeSitePhoneId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PracticeSiteId).IsRequired();
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.PracticeSite).WithMany(p => p.PracticeSitePhones).HasForeignKey(p => p.PracticeSiteId).WillCascadeOnDelete(false);
            HasRequired(p => p.Phone).WithMany(p => p.PracticeSitePhones).HasForeignKey(p => p.PhoneId).WillCascadeOnDelete(false);
        }
    }
}
