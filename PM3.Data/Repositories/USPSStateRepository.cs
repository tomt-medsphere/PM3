using PM3.Data.Infrastructure;
using PM3.Model.Models;

namespace PM3.Data.Repositories
{
    public class USPSStateRepository : RepositoryBase<USPSState>, IUSPSStateRepository
    {
        public USPSStateRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
    public interface IUSPSStateRepository : IRepository<USPSState>
    {
    }
}
