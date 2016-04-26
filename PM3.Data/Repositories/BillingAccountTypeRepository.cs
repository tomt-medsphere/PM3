using PM3.Data.Infrastructure;
using PM3.Model.Models;

namespace PM3.Data.Repositories
{
    public class BillingAccountTypeRepository : RepositoryBase<BillingAccountType>, IBillingAccountTypeRepository
    {
        public BillingAccountTypeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
    public interface IBillingAccountTypeRepository : IRepository<BillingAccountType>
    {
    }
}
