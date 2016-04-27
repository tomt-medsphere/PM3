using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class CDCRace
    {
        public string CDCRaceId { get; set; }
        public string HCode { get; set; }
        public string Description { get; set; }
        public string MuCode { get; set; }

        // children
        public virtual List<PersonRace> PersonRaces { get; set; }
    }
}
