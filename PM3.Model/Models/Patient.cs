using System;

namespace PM3.Model.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public int PersonId { get; set; }
        public string XRayId { get; set; }
        public string ChartNumber { get; set; }
        public string PracticeProviderId { get; set; }
        public bool InfoRelease { get; set; }
        public string InfoReleaseTypeId { get; set; }
        public DateTime InfoReleaseDate { get; set; }
        public bool PayProvider { get; set; }
        public string PayProviderTypeId { get; set; }
        public DateTime PayProviderDate { get; set; }
        public bool HipaaRelease { get; set; }
        public DateTime HipaaReleaseDate { get; set; }
        public string Pcpid { get; set; }
        public DateTime PcpLastSeen { get; set; }
        public DateTime Lmp { get; set; }
        public DateTime Edc { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Person Person { get; set; }
        public virtual Provider PracticeProvider { get; set; }
        public virtual InfoReleaseType InfoReleaseType { get; set; }
        public virtual PayProviderType PayProviderType { get; set; }
        public virtual ExtProvider ExternalProvider { get; set; }
    }
}
