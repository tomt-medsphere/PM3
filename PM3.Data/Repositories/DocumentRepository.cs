using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Data.Infrastructure;
using PM3.Model.Models;

namespace PM3.Data.Repositories
{
    public class DocumentRepository : RepositoryBase<Document>, IDocumentRepository
    {
        public DocumentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IDocumentRepository : IRepository<Document>
    {
    }
}
