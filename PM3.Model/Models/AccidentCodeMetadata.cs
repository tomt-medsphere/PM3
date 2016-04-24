using System.ComponentModel.DataAnnotations;

namespace PM3.Model.Models
{
    public class AccidentCodeMetadata
    {
        [StringLength(10)]
        [Display(Name = "Accident Code ID")]
        public string AccidentCodeId;

        [StringLength(100)] public string Description;
    }
}
