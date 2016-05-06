using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class User
    {
        public string UserId { get; set; }
        public int UserIdInt { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixId { get; set; }
        public string Password { get; set; }
        public bool Inactive { get; set; }
        public DateTime LastLogIn { get; set; }
        public DateTime LastLogOut { get; set; }
        public DateTime PasswordExpires { get; set; }
        public bool UserLockedOut { get; set; }

        // parents
        public virtual Suffix Suffix { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
        public virtual List<ChargeBatch> ChargeBatches { get; set; }
        public virtual List<ClaimRun> ClaimRuns { get; set; }
        public virtual List<ClosingRun> ClosingRuns { get; set; }
        public virtual List<EDI270> EDI270s { get; set; }
        public virtual List<EDI277STCAction> EDI277Actions { get; set; }
        public virtual List<EDIInbox> EDIInboxes { get; set; }
        public virtual List<EDISession> EDISessions { get; set; }
        public virtual List<PatientNote> CreatedPatientNotes { get; set; }
        public virtual List<PatientNote> AssignedPatientNotes { get; set; }
        public virtual List<PostingPeriod> CreatedPostingPeriods { get; set; }
        public virtual List<PostingPeriod> ClosedPostingPeriods { get; set; }
        public virtual List<PrepError> PrepErrors { get; set; }
        public virtual List<PrepRequest> PrepRequests { get; set; }
        public virtual List<PrepRun> PrepRuns { get; set; }
        public virtual List<StatementRun> StatementRuns { get; set; }
        public virtual List<TX> TXs { get; set; }
        public virtual List<TXBatch> TXBatches { get; set; }
        public virtual List<UserAccess> UserAccesses { get; set; }
    }
}
