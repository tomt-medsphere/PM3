using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class DocumentCategoryConfiguation : EntityTypeConfiguration<DocumentCategory>
    {
        public DocumentCategoryConfiguation()
        {
            ToTable("DocumentCategory");
            HasKey(p => p.DocumentCategoryId);
            Property(p => p.DocumentCategoryId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.DocumentTypes).WithRequired(p => p.DocumentCategory);
        }
    }
}
