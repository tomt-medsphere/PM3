using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
