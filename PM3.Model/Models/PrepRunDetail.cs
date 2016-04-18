using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PrepRunDetail
    {
        public int PrepRunDetailID { get; set; }
        public int PrepRunID { get; set; }
        public int ChargeID { get; set; }
        public string InsPlanID { get; set; }
        public DateTime FirstDateOfService { get; set; }
        public decimal TotalFee { get; set; }
        public decimal BilledFee { get; set; }
        public string PassedPrep { get; set; }
        public string EDIPartnerID { get; set; }
        public string InsFormTypeID { get; set; }

        // parents
        public virtual PrepRun PrepRun { get; set; }
        public virtual Charge Charge { get; set; }
        public virtual InsPlan InsPlan { get; set; }
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual InsFormType InsFormType { get; set; }
    }
}
