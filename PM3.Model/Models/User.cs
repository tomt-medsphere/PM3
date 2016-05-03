using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixId { get; set; }
        public bool Administrator { get; set; }
        public bool PracticeTables { get; set; }
        public bool Scheduling { get; set; }
        public bool Encounters { get; set; }
        public bool Payments { get; set; }
        public bool Closing { get; set; }
        public string Password { get; set; }
        public bool Inactive { get; set; }
        public bool Management { get; set; }
        public bool PlanProfilesExpert { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
        public virtual List<ChargeBatch> ChargeBatches { get; set; }
        public virtual List<ClaimRun> ClaimRuns { get; set; }
        public virtual List<ClosingRun> ClosingRuns { get; set; }

        public virtual List<EDI270> EDI270s { get; set; }
        public virtual List<EDI277STCAction> EDI277Actions { get; set; }
        public virtual List<EDIInbox> EDIInboxes { get; set; }
        public virtual List<PatientNote> CreatedPatientNotes { get; set; }
        public virtual List<PatientNote> AssignedPatientNotes { get; set; }
    }
}
