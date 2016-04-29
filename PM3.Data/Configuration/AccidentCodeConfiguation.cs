using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class AccidentCodeConfiguation : EntityTypeConfiguration<AccidentCode>
    {
        public AccidentCodeConfiguation()
        {
            ToTable("AccidentCode");
            HasKey(p => p.AccidentCodeId);
            Property(p => p.AccidentCodeId).IsRequired().HasMaxLength(10); //.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() {IsClustered=true})); 
            Property(p => p.Description).IsRequired().HasColumnType("varchar").HasMaxLength(100);

            // children
            HasMany(c => c.Charges).WithOptional(c => c.AccidentCode);
        }
    }
}
