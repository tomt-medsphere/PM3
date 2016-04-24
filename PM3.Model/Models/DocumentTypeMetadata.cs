using System.ComponentModel.DataAnnotations;

namespace PM3.Model.Models
{
    public class DocumentTypeMetadata
    {
        [StringLength(10)]
        [Display(Name = "Document Type ID")]
        public string DocumentTypeId;

        [StringLength(100)]
        public string Description;

        [StringLength(10)]
        [Display(Name = "Document Category ID")]
        public string DocumentCategoryId;
    }
}