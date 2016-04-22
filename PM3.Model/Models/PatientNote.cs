using System;

namespace PM3.Model.Models
{
    public class PatientNote
    {
        public int PatientNoteId { get; set; }
        public int PatientId { get; set; }
        public string PatientNoteTypeId { get; set; }
        public bool Flash { get; set; }
        public bool Stop { get; set; }
        public bool Statement { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDateTIme { get; set; }
        public string CreatedUserId { get; set; }
        public string AssignedUserId { get; set; }
        public DateTime? TickleDateTime { get; set; }
        public int? StatementRunId { get; set; }
        public int? ChargeId { get; set; }

        // parents
        public virtual Patient Patient { get; set; }
        public virtual PatientNoteType PatientNoteType { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User AssignedTo { get; set; }
        public virtual Charge Charge { get; set; }
    }
}
