using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CAGCodeConfiguation : EntityTypeConfiguration<CAGCode>
    {
        public CAGCodeConfiguation()
        {
            ToTable("CAGCode");
            HasKey(p => p.CAGCodeId);
            Property(p => p.CAGCodeId)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() {IsClustered = true}));
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.StartDate).IsRequired();
            Property(p => p.EndDate).IsOptional();

            // children
            HasMany(c => c.TX).WithRequired(c => c.CAGCode);
            HasMany(c => c.TXCAS).WithRequired(c => c.CAGCode);
        }
    }
}
