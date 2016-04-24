using System.ComponentModel.DataAnnotations;

namespace PM3.Model.Models
{
    public class DocumentCategoryMetadata
    {
        [StringLength(10)]
        [Display(Name = "Document Category ID")]
        public string DocumentCategoryId;

        [StringLength(100)]
        public string Description;
    }
}