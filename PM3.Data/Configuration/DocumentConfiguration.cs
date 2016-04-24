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
    public class DocumentConfiguation : EntityTypeConfiguration<Document>
    {
        public DocumentConfiguation()
        {
            ToTable("Document");
            HasKey(p => p.DocumentId);
            Property(p => p.DocumentId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(p => p.DocumentTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.UserId).IsRequired().HasMaxLength(255);

            //// parents
            //HasRequired(p => p.DocumentType).WithMany(p => p.Documents).HasForeignKey(p => p.DocumentTypeId).WillCascadeOnDelete(false);

            //// children
        }
    }
}
