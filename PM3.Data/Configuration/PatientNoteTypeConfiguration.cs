using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PatientNoteTypeConfiguration : EntityTypeConfiguration<PatientNoteType>
    {
        public PatientNoteTypeConfiguration()
        {
            ToTable("PatientNoteType");
            HasKey(p => p.PatientNoteTypeId);
            Property(p => p.PatientNoteTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.PatientNotes).WithRequired(c => c.PatientNoteType);
        }
    }
}
