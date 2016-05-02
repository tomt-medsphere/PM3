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
    public class PatientConfiguration : EntityTypeConfiguration<Patient>
    {
        public PatientConfiguration()
        {
            ToTable("Patient");
            HasKey(p => p.PatientId);
            Property(p => p.PatientId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PersonId).IsRequired();
            Property(p => p.InfoReleaseTypeId).IsOptional().HasMaxLength(10);
            Property(p => p.InfoReleaseDate).IsOptional();
            Property(p => p.PayProviderTypeId).IsOptional().HasMaxLength(10);
            Property(p => p.PayProviderDate).IsOptional();
            Property(p => p.PracticeProviderId).IsOptional().HasMaxLength(10);
            Property(p => p.PCPId).IsOptional().HasMaxLength(10);
            Property(p => p.PCPLastSeen).IsOptional();
            Property(p => p.ChartNumber).IsOptional().HasMaxLength(255);
            Property(p => p.HIPAARelease).IsRequired();
            Property(p => p.HIPAAReleaseDate).IsOptional();
            Property(p => p.LMP).IsOptional();
            Property(p => p.EDC).IsRequired();
            Property(p => p.Inactive).IsRequired();

            // parents
            HasRequired(p => p.Person).WithMany(p => p.Patients).HasForeignKey(p => p.PersonId).WillCascadeOnDelete(false);
            HasOptional(p => p.PracticeProvider).WithMany(p => p.Patients).HasForeignKey(p => p.PracticeProviderId).WillCascadeOnDelete(false);
            HasOptional(p => p.PCP).WithMany(p => p.PCPPatients).HasForeignKey(p => p.PCPId).WillCascadeOnDelete(false);
            HasOptional(p => p.RefProvider).WithMany(p => p.RefPatients).HasForeignKey(p => p.RefProviderId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.InsCoverages).WithRequired(c => c.Patient);
            HasMany(c => c.PatientBillingAccounts).WithRequired(c => c.Patient);
            HasMany(c => c.PatientNotes).WithRequired(c => c.Patient);
            //HasMany(c => c.PatientEHR).WithRequired(c => c.Patient);
            HasMany(c => c.Charges).WithRequired(c => c.Patient);
            HasMany(c => c.FacilityAdmissions).WithRequired(c => c.Patient);
            HasMany(c => c.ChargeServices).WithRequired(c => c.Patient);


        }
    }
}
