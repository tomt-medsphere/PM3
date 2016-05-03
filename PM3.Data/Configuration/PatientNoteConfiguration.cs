using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PatientNoteConfiguration : EntityTypeConfiguration<PatientNote>
    {
        public PatientNoteConfiguration()
        {
            ToTable("PatientNote");
            HasKey(p => p.PatientNoteId);
            Property(p => p.PatientNoteId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PatientId).IsRequired();
            Property(p => p.PatientNoteTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Flash).IsRequired();
            Property(p => p.Stop).IsRequired();
            Property(p => p.Statement).IsRequired();
            Property(p => p.Note).IsOptional().HasColumnType("longtext");
            Property(p => p.CreatedDateTIme).IsRequired();
            Property(p => p.CreatedUserId).IsRequired().HasMaxLength(255);
            Property(p => p.AssignedUserId).IsOptional().HasMaxLength(255);
            Property(p => p.TickleDateTime).IsOptional();
            Property(p => p.StatementRunId).IsOptional();
            Property(p => p.ChargeId).IsOptional();

            // parents
            HasRequired(p => p.Patient).WithMany(p => p.PatientNotes).HasForeignKey(p => p.PatientId).WillCascadeOnDelete(false);
            HasRequired(p => p.PatientNoteType).WithMany(p => p.PatientNotes).HasForeignKey(p => p.PatientNoteTypeId).WillCascadeOnDelete(false);
            HasRequired(p => p.CreatedUser).WithMany(p => p.CreatedPatientNotes).HasForeignKey(p => p.CreatedUserId).WillCascadeOnDelete(false);
            HasOptional(p => p.AssignedUser).WithMany(p => p.AssignedPatientNotes).HasForeignKey(p => p.AssignedUserId).WillCascadeOnDelete(false);
            HasOptional(p => p.Charge).WithMany(p => p.PatientNotes).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
        }
    }
}
