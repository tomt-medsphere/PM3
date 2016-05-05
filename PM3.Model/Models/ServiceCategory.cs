using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ServiceCategory
    {
        public string ServiceCategoryId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }

        // children
        public virtual List<Service> Services { get; set; }
    }
}
