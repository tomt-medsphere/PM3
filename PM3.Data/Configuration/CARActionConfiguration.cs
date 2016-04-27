using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CARActionConfiguation : EntityTypeConfiguration<CARAction>
    {
        public CARActionConfiguation()
        {
            ToTable("CARAction");
            HasKey(p => p.CARCodeId);
            Property(p => p.CARCodeId).IsRequired().HasMaxLength(2);
            Property(p => p.ShortDescription).IsRequired().HasMaxLength(30);
            Property(p => p.SetReview).IsRequired();
            Property(p => p.CreateTXNote).IsRequired();
            Property(p => p.TXCodeId).HasMaxLength(10);

            // parents
            HasRequired(p => p.CARCode).WithMany(p => p.CARActions).HasForeignKey(p => p.CARCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.TXCode).WithMany(p => p.CARActions).HasForeignKey(p => p.TXCodeId).WillCascadeOnDelete(false);
        }
    }
}
