using System.ComponentModel.DataAnnotations;

namespace PM3.Model.Models
{
    public class DocumentMetadata
    {
        [Display(Name = "Document ID")]
        public string DocumentId;

        [StringLength(10)]
        [Display(Name = "Document Type ID")]
        public string DocumentTypeId;

        [StringLength(255)]
        [Display(Name = "User ID")]
        public string UserId;
    }
}