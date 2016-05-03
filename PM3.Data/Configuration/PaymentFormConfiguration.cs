using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PaymentFormConfiguration : EntityTypeConfiguration<PaymentForm>
    {
        public PaymentFormConfiguration()
        {
            ToTable("PaymentForm");
            HasKey(p => p.PaymentFormId);
            Property(p => p.PaymentFormId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.TXCodes).WithRequired(c => c.PaymentForm);
            HasMany(c => c.TXBatches).WithRequired(c => c.PaymentForm);
            HasMany(c => c.TXs).WithRequired(c => c.PaymentForm);
        }
    }
}
