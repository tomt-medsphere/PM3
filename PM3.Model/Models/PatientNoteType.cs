using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PatientNoteType
    {
        public string PatientNoteTypeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<PatientNote> PatientNotes { get; set; }
    }
}
