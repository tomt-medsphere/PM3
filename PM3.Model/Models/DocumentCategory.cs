using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    [MetadataType(typeof(DocumentCategoryMetadata))]
    public partial class DocumentCategory
    {
        public string DocumentCategoryId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<DocumentType> DocumentTypes { get; set; }
    }
}
