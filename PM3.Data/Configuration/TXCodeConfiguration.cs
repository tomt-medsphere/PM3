using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class TXCodeConfiguration : EntityTypeConfiguration<TXCode>
    {
        public TXCodeConfiguration()
        {
            ToTable("TXCode");
            HasKey(p => p.TXCodeId);
            Property(p => p.TXCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.TXTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.PaymentFormId).IsRequired().HasMaxLength(10);
            Property(p => p.PaymentCategoryId).IsRequired().HasMaxLength(10);

            // parents
            HasRequired(p => p.TXType).WithMany(p => p.TXCodes).HasForeignKey(p => p.TXTypeId).WillCascadeOnDelete(false);
            HasRequired(p => p.PaymentForm).WithMany(p => p.TXCodes).HasForeignKey(p => p.PaymentFormId).WillCascadeOnDelete(false);
            HasRequired(p => p.PaymentCategory).WithMany(p => p.TxCodes).HasForeignKey(p => p.PaymentCategoryId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.CARActions).WithOptional(c => c.TXCode);
            HasMany(c => c.TXBatches).WithOptional(c => c.TXCode);
            HasMany(c => c.TXs).WithRequired(c => c.TxCode);
        }
    }
}
