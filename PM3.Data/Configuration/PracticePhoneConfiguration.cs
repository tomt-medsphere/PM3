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
    public class PracticePhoneConfiguration : EntityTypeConfiguration<PracticePhone>
    {
        public PracticePhoneConfiguration()
        {
            ToTable("PracticePhone");
            HasKey(p => p.PracticePhoneId);
            Property(p => p.PracticePhoneId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PracticeId).IsRequired();
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.Practice).WithMany(p => p.PracticePhones).HasForeignKey(p => p.PracticeId).WillCascadeOnDelete(false);
            HasRequired(p => p.Phone).WithMany(p => p.PracticePhones).HasForeignKey(p => p.PhoneId).WillCascadeOnDelete(false);
        }
    }
}
