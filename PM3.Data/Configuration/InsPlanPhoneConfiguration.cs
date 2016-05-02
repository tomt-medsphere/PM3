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
    public class InsPlanPhoneConfiguration : EntityTypeConfiguration<InsPlanPhone>
    {
        public InsPlanPhoneConfiguration()
        {
            ToTable("InsPlanPhone");
            HasKey(p => p.InsPlanPhoneId);
            Property(p => p.InsPlanPhoneId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.InsPlanId).IsRequired().HasMaxLength(10);
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Department).IsOptional().HasMaxLength(255);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.InsPlan).WithMany(p => p.InsPlanPhones).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
            HasRequired(p => p.Phone).WithMany(p => p.InsPlanPhones).HasForeignKey(p => p.PhoneId).WillCascadeOnDelete(false);
        }
    }
}
