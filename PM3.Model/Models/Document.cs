using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    [MetadataType(typeof(DocumentMetadata))]
    public class Document
    {
        public Guid DocumentId { get; set; }
        public string DocumentTypeId { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual DocumentType DocumentType { get; set; }
        public virtual User User { get; set; }
    }
}
