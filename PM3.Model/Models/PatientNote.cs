using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PatientNote
    {
        public int PatientNoteID { get; set; }
        public int PatientID { get; set; }
        public string PatientNoteTypeID { get; set; }
        public bool Flash { get; set; }
        public bool Stop { get; set; }
        public bool Statement { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDateTIme { get; set; }
        public string CreatedUserID { get; set; }
        public string AssignedUserID { get; set; }
        public DateTime? TickleDateTime { get; set; }
        public int? StatementRunID { get; set; }
        public int? ChargeID { get; set; }

        // parents
        public virtual Patient Patient { get; set; }
        public virtual PatientNoteType PatientNoteType { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User AssignedTo { get; set; }
        public virtual Charge Charge { get; set; }
    }
}
