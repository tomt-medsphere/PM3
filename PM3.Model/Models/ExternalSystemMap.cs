namespace PM3.Model.Models
{
    public class ExternalSystemMap
    {
        public int ExternalSystemMapId { get; set; }
        public string ExternalSystemId { get; set; }
        public string ExternalEntityId { get; set; }
        public string EntityTypeId { get; set; }
        public string EntityId { get; set; }

        // parents
        public virtual ExternalSystem ExternalSystem { get; set; }
        public virtual EntityType EntityType { get; set; }
    }
}
