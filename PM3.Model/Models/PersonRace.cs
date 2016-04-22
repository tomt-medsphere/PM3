namespace PM3.Model.Models
{
    public class PersonRace
    {
        public int PersonRaceId { get; set; }
        public int PersonId { get; set; }
        public string CdcRaceId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Person Person { get; set;}
        public virtual CdcRace CdcRace { get; set; }
    }
}
