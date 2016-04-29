using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class FacilityAdmissionConfiguration : EntityTypeConfiguration<FacilityAdmission>
    {
        public FacilityAdmissionConfiguration()
        {
            ToTable("FacilityAdmission");
            HasKey(p => p.FacilityAdmissionId);
            Property(p => p.FacilityAdmissionId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PatientId).IsRequired();
            Property(p => p.ExtFacilityId).IsRequired();
            Property(p => p.Admitted).IsRequired();
            Property(p => p.Discharged).IsOptional();
            Property(p => p.Note).IsOptional().HasMaxLength(255);
            Property(p => p.MedicalRecordNumber).IsOptional().HasMaxLength(30);

            // parents
            HasRequired(p => p.ExtFacility).WithMany(p => p.FacilityAdmissions).HasForeignKey(p => p.ExtFacilityId).WillCascadeOnDelete(false);
            HasRequired(p => p.Patient).WithMany(p => p.FacilityAdmissions).HasForeignKey(p => p.PatientId).WillCascadeOnDelete(false);
        }
    }
}
