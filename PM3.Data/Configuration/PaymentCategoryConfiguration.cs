using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PaymentCategoryConfiguration : EntityTypeConfiguration<PaymentCategory>
    {
        public PaymentCategoryConfiguration()
        {
            ToTable("PaymentCategory");
            HasKey(p => p.PaymentCategoryId);
            Property(p => p.PaymentCategoryId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.TxCodes).WithRequired(c => c.PaymentCategory);
        }
    }
}
