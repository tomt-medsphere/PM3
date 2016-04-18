using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data.Configuration
{
    public class CARActionConfiguation : EntityTypeConfiguration<CARAction>
    {
        public CARActionConfiguation()
        {
            ToTable("CARAction");
            HasKey(p => p.CARCodeID);
            Property(p => p.CARCodeID).IsRequired().HasMaxLength(10);
            Property(p => p.ShortDescription).IsRequired().HasMaxLength(60);
            Property(p => p.SetReview).IsRequired();
            Property(p => p.CreateTxNote).IsRequired();
            Property(p => p.TXCodeID).HasMaxLength(10);
        }
    }
}
