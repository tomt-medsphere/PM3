using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CARActionConfiguation : EntityTypeConfiguration<CARAction>
    {
        public CARActionConfiguation()
        {
            ToTable("CARAction");
            HasKey(p => p.CarCodeId);
            Property(p => p.CarCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.ShortDescription).IsRequired().HasMaxLength(60);
            Property(p => p.SetReview).IsRequired();
            Property(p => p.CreateTxNote).IsRequired();
            Property(p => p.TxCodeId).HasMaxLength(10);
        }
    }
}
