namespace PM3.Model.Models
{
    public class ChargeServiceMod
    {
        public int ChargeServiceModId { get; set; }
        public int ChargeServiceId { get; set; }
        public string HCPCSModifierId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ChargeService ChargeService { get; set;}
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
