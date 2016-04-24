using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PM3.Model.Models
{
    [MetadataType(typeof(AccidentCodeMetadata))]
    public partial class AccidentCode
    {
        public string AccidentCodeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
    }
}