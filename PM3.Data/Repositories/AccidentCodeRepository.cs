using PM3.Data.Infrastructure;
using PM3.Model.Models;

namespace PM3.Data.Repositories
{
    public class AccidentCodeRepository : RepositoryBase<AccidentCode>, IAccidentCodeRepository
    {
        public AccidentCodeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
    public interface IAccidentCodeRepository : IRepository<AccidentCode>
    {
    }
}
