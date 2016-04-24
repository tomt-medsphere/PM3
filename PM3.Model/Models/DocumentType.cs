using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    [MetadataType(typeof(DocumentTypeMetadata))]
    public partial class DocumentType
    {
        public string DocumentTypeId { get; set; }
        public string Description { get; set; }
        public string DocumentCategoryId { get; set; }

        // parent
        public virtual DocumentCategory DocumentCategory { get; set; }

        // children
        public virtual List<Document> Documents { get; set; }
    }
}
