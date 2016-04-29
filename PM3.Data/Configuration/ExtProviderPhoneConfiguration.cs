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
    public class ExtProviderPhoneConfiguration : EntityTypeConfiguration<ExtProviderPhone>
    {
        public ExtProviderPhoneConfiguration()
        {
            ToTable("ExtProviderPhone");
            HasKey(p => p.ExtProviderPhoneId);
            Property(p => p.ExtProviderPhoneId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ExtProviderId).IsRequired();
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            //HasRequired(p => p.ExtProvider).WithMany(p => p.ExtProviderPhones).HasForeignKey(p => p.ExtProviderId).WillCascadeOnDelete(false);
            //HasRequired(p => p.Phone).WithMany(p => p.ExtProviderPhones).HasForeignKey(p => p.PhoneId).WillCascadeOnDelete(false);

        }
    }
}
