using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class HCPCSRVU
    {
        public int HCPCSRVUId { get; set; }
        public string HCPCSId { get; set; }
        public string HCPCSModifierId { get; set; }
        public int Year { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal WorkRVU { get; set; }
        public decimal NonFacPracRVU { get; set; }
        public decimal FacPracRVU { get; set; }
        public decimal MalpracRVU { get; set; }
        public string PcTc { get; set; }
        public string GlobalDays { get; set; }
        public decimal PreOpPct { get; set; }
        public decimal IntraOpPct { get; set; }
        public decimal PostOpPct { get; set; }
        public string MultiProc { get; set; }
        public string BilatSurg { get; set; }
        public string AsstSurg { get; set; }
        public string CoSurg { get; set; }
        public string TeamSurg { get; set; }
        public string EndoBase { get; set; }
        public decimal CF { get; set; }
        public string Supervision { get; set; }
        public string CalcFlag { get; set; }
        public string DxImgFamily { get; set; }
        public decimal OPPSNonFacPracExp { get; set; }
        public decimal OPPSFacPracExp { get; set; }
        public decimal OPPSMalPracExp { get; set; }
        public string ShortDescription { get; set; }
        public string MediumDescription { get; set; }
        public bool NOC { get; set; }

        // parents
        public virtual HCPCS HCPCS { get; set; }

    }
}
