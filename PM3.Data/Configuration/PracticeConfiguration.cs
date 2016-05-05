using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PracticeConfiguration : EntityTypeConfiguration<Practice>
    {
        public PracticeConfiguration()
        {
            ToTable("Practice");
            HasKey(p => p.PracticeId);
            Property(p => p.PracticeId).IsRequired().HasMaxLength(10);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.EntityTypeId).IsRequired().HasMaxLength(3);
            Property(p => p.EIN).IsRequired().HasMaxLength(9);
            Property(p => p.Note).IsOptional().HasColumnType("text");
            Property(p => p.LastName).IsOptional().HasMaxLength(60);
            Property(p => p.FirstName).IsOptional().HasMaxLength(35);
            Property(p => p.MiddleName).IsOptional().HasMaxLength(25);
            Property(p => p.SuffixId).IsOptional().HasMaxLength(10);
            Property(p => p.NPI).IsOptional().HasMaxLength(10);
            Property(p => p.TaxonomyCodeId).IsOptional().HasMaxLength(30);
            Property(p => p.AddressStreet).IsRequired().HasMaxLength(55);
            Property(p => p.AddressOther).IsOptional().HasMaxLength(55);
            Property(p => p.City).IsRequired().HasMaxLength(30);
            Property(p => p.USPSStateId).IsRequired().HasMaxLength(2);
            Property(p => p.PostalCode).IsRequired().HasMaxLength(15);
            Property(p => p.USPSCountryId).IsRequired().HasMaxLength(2);
            Property(p => p.RemitStreet).IsRequired().HasMaxLength(55);
            Property(p => p.RemitOther).IsOptional().HasMaxLength(55);
            Property(p => p.RemitCity).IsRequired().HasMaxLength(30);
            Property(p => p.RemitUSPSStateId).IsRequired().HasMaxLength(2);
            Property(p => p.RemitPostalCode).IsRequired().HasMaxLength(15);
            Property(p => p.RemitUSPSCountryId).IsRequired().HasMaxLength(2);
            Property(p => p.MaxPasswordAge).IsRequired();
            Property(p => p.MinPasswordLength).IsRequired();
            Property(p => p.MaxPasswordFailure).IsRequired();
            Property(p => p.ScreenTimeout).IsRequired();
            Property(p => p.LoginFailureWithinMin).IsRequired();

            // parents
            HasRequired(p => p.USPSState).WithMany(p => p.Practices).HasForeignKey(p => p.USPSStateId).WillCascadeOnDelete(false);
            HasRequired(p => p.USPSCountry).WithMany(p => p.Practices).HasForeignKey(p => p.USPSCountryId).WillCascadeOnDelete(false);
            HasRequired(p => p.RemitUSPSState).WithMany(p => p.RemitPractices).HasForeignKey(p => p.RemitUSPSStateId).WillCascadeOnDelete(false);
            HasRequired(p => p.RemitUSPSCountry).WithMany(p => p.RemitPractices).HasForeignKey(p => p.RemitUSPSCountryId).WillCascadeOnDelete(false);
            HasRequired(p => p.TaxonomyCode).WithMany(p => p.Practices).HasForeignKey(p => p.TaxonomyCodeId).WillCascadeOnDelete(false);

            // children
            HasOptional(c => c.PracticeEHR).WithRequired(c => c.Practice);
        }
    }
}
