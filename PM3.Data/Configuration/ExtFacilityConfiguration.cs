using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ExtFacilityConfiguration : EntityTypeConfiguration<ExtFacility>
    {
        public ExtFacilityConfiguration()
        {
            ToTable("ExtFacilty");
            HasKey(p => p.ExtFacilityId);
            Property(p => p.ExtFacilityId).IsRequired().HasMaxLength(10);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.AddressStreet).IsOptional().HasMaxLength(55);
            Property(p => p.AddressOther).IsOptional().HasMaxLength(55);
            Property(p => p.City).IsOptional().HasMaxLength(30);
            Property(p => p.USPSStateId).IsOptional().HasMaxLength(2);
            Property(p => p.PostalCode).IsOptional().HasMaxLength(15);
            Property(p => p.USPSCountryId).IsOptional().HasMaxLength(2);
            Property(p => p.NPI).IsOptional().HasMaxLength(10);
            Property(p => p.Inactive).IsRequired();

            // parents
            HasOptional(p => p.USPSState).WithMany(p => p.ExtFacilities).HasForeignKey(p => p.USPSStateId).WillCascadeOnDelete(false);
            HasOptional(p => p.USPSCountry).WithMany(p => p.ExtFacilities).HasForeignKey(p => p.USPSCountryId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.Charges).WithOptional(c => c.ExtFacility);
            HasMany(c => c.FacilityAdmissions).WithRequired(c => c.ExtFacility);
            HasMany(c => c.ExtFacilityPhones).WithRequired(c => c.ExtFacility);
        }
    }
}
