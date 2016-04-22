using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EntityType
    {
        public string EntityTypeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ExternalSystemMap> ExternalSystemMaps { get; set; }
    }
}
