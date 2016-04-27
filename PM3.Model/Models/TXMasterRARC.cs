namespace PM3.Model.Models
{
    public class TXMasterRARC
    {
        public int TXMasterRARCid { get; set; }
        public int TXMasterId { get; set; }
        public string RARCId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual TXMaster TXMaster { get; set; }
        public virtual RARC RARC { get; set; }
    }
}
