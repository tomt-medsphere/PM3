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
    public class EmployerConfiguration : EntityTypeConfiguration<Employer>
    {
        public EmployerConfiguration()
        {
            ToTable("Employer");
            HasKey(p => p.EmployerId);
            Property(p => p.EmployerId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name).IsRequired().IsOptional().HasMaxLength(60);
            Property(p => p.AddressStreet).IsOptional().HasMaxLength(55);
            Property(p => p.AddressOther).IsOptional().HasMaxLength(55);
            Property(p => p.City).IsOptional().HasMaxLength(30);
            Property(p => p.USPSStateId).IsOptional().HasMaxLength(2);
            Property(p => p.PostalCode).IsOptional().HasMaxLength(15);
            Property(p => p.USPSCountryId).IsOptional().HasMaxLength(2);
            Property(p => p.Note).IsOptional().HasMaxLength(255);
            Property(p => p.Inactive).IsRequired();

            // parents
            HasOptional(p => p.USPSState).WithMany(p => p.Employers).HasForeignKey(p => p.USPSStateId).WillCascadeOnDelete(false);
            HasOptional(p => p.USPSCountry).WithMany(p => p.Employers).HasForeignKey(p => p.USPSCountryId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.Persons).WithOptional(c => c.Employer);
            HasMany(c => c.EmployerPhones).WithRequired(c => c.Employer);
        }
    }
}
