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
    public class ExtFacilityPhoneConfiguration : EntityTypeConfiguration<ExtFacilityPhone>
    {
        public ExtFacilityPhoneConfiguration()
        {
            ToTable("ExtFacilityPhone");
            HasKey(p => p.ExtFacilityPhoneId);
            Property(p => p.ExtFacilityPhoneId).IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ExtFacilityId).IsRequired().HasMaxLength(10);
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.ExtFacility).WithMany(p => p.ExtFacilityPhones).HasForeignKey(p => p.ExtFacilityId).WillCascadeOnDelete(false);
            HasRequired(p => p.Phone).WithMany(p => p.ExtFacilityPhones).HasForeignKey(p => p.PhoneId).WillCascadeOnDelete(false);
        }
    }
}
