using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("MBSUser");
            HasKey(p => p.UserId);
            Property(p => p.UserId).IsRequired().HasMaxLength(255);
            Property(p => p.UserIdInt).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() {IsUnique = true}));
            Property(p => p.LastName).IsRequired().HasMaxLength(60);
            Property(p => p.FirstName).IsRequired().HasMaxLength(35);
            Property(p => p.MiddleName).IsOptional().HasMaxLength(25);
            Property(p => p.SuffixId).IsOptional().HasMaxLength(10);
            Property(p => p.Password).IsRequired().HasColumnType("text");
            Property(p => p.Inactive).IsRequired();
            Property(p => p.LastLogIn).IsOptional();
            Property(p => p.LastLogOut).IsOptional();
            Property(p => p.PasswordExpires).IsOptional();
            Property(p => p.UserLockedOut).IsRequired();

            // parents
            HasOptional(p => p.Suffix).WithMany(p => p.Users).HasForeignKey(p => p.SuffixId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.ClaimRuns).WithRequired(c => c.User);
            HasMany(c => c.EDI277Actions).WithRequired(c => c.User);
            HasMany(c => c.ClosingRuns).WithRequired(c => c.User);
            HasMany(c => c.EDI270s).WithRequired(c => c.User);
            HasMany(c => c.EDIInboxes).WithRequired(c => c.User);
            HasMany(c => c.EDISessions).WithRequired(c => c.User);
            HasMany(c => c.ChargeBatches).WithRequired(c => c.User);
            HasMany(c => c.CreatedPatientNotes).WithRequired(c => c.CreatedUser);
            HasMany(c => c.AssignedPatientNotes).WithOptional(c => c.AssignedUser);
            HasMany(c => c.CreatedPostingPeriods).WithRequired(c => c.CreatedUser);
            HasMany(c => c.ClosedPostingPeriods).WithOptional(c => c.ClosedUser);
            HasMany(c => c.PrepErrors).WithOptional(c => c.User);
            HasMany(c => c.PrepRequests).WithRequired(c => c.User);
            HasMany(c => c.StatementRuns).WithRequired(c => c.User);
            HasMany(c => c.TXBatches).WithRequired(c => c.User);
            HasMany(c => c.TXs).WithRequired(c => c.User);
            HasMany(c => c.Charges).WithRequired(c => c.User);
            HasMany(c => c.UserAccesses).WithRequired(c => c.User);
        }
    }
}
