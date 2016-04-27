using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data.Configuration
{
    public class DocumentTypeConfiguation : EntityTypeConfiguration<DocumentType>
    {
        public DocumentTypeConfiguation()
        {
            ToTable("DocumentType");
            HasKey(p => p.DocumentTypeId);
            Property(p => p.DocumentTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            //// parents
            HasRequired(p => p.DocumentCategory).WithMany(p => p.DocumentTypes).HasForeignKey(p => p.DocumentCategoryId).WillCascadeOnDelete(false);

            //// children
        }
    }
}
