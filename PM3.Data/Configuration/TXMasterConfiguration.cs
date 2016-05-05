using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class TXMasterConfiguration : EntityTypeConfiguration<TXMaster>
    {
        public TXMasterConfiguration()
        {
            ToTable("TXMaster");
            HasKey(p => p.TXMasterId);
            Property(p => p.TXMasterId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TXBatchId).IsRequired();
            Property(p => p.EntryDateTime).IsRequired();
            Property(p => p.Amount).IsRequired().HasPrecision(18, 2);
            Property(p => p.Note).IsOptional().HasColumnType("text");
            Property(p => p.InsPlanId).IsOptional().HasMaxLength(10);
            Property(p => p.ICN).IsOptional().HasMaxLength(30);

            // parents
            HasRequired(p => p.TXBatch).WithMany(p => p.TXMasters).HasForeignKey(p => p.TXBatchId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.TXs).WithRequired(c => c.TXMaster);
            HasMany(c => c.TXMasterRARC).WithRequired(c => c.TXMaster);
        }
    }
}
