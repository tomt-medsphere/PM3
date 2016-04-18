using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public int PersonID { get; set; }
        public string XRayID { get; set; }
        public string ChartNumber { get; set; }
        public string PracticeProviderID { get; set; }
        public bool InfoRelease { get; set; }
        public string InfoReleaseTypeID { get; set; }
        public DateTime InfoReleaseDate { get; set; }
        public bool PayProvider { get; set; }
        public string PayProviderTypeID { get; set; }
        public DateTime PayProviderDate { get; set; }
        public bool HIPAARelease { get; set; }
        public DateTime HIPAAReleaseDate { get; set; }
        public string PCPID { get; set; }
        public DateTime PCPLastSeen { get; set; }
        public DateTime LMP { get; set; }
        public DateTime EDC { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Person Person { get; set; }
        public virtual Provider PracticeProvider { get; set; }
        public virtual InfoReleaseType InfoReleaseType { get; set; }
        public virtual PayProviderType PayProviderType { get; set; }
        public virtual ExtProvider ExternalProvider { get; set; }
    }
}
