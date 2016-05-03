using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PatientEHRConfiguration : EntityTypeConfiguration<PatientEHR>
    {
        public PatientEHRConfiguration()
        {
            ToTable("PatientEHR");
            HasKey(p => p.PatientId);
            Property(p => p.PatientId).IsRequired();

            // parents
            HasRequired(p => p.Patient).WithOptional(p => p.PatientEHR);
        }
    }
}
