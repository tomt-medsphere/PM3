namespace PM3.Model.Models
{
    public class TxMasterRARC
    {
        public int TxMasterRARCid { get; set; }
        public int TxMasterId { get; set; }
        public string RARCId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual TxMaster TxMaster { get; set; }
        public virtual RARC RARC { get; set; }
    }
}
