using PM3.Data.Infrastructure;
using PM3.Model.Models;

namespace PM3.Data.Repositories
{
    public class DocumentCategoryRepository : RepositoryBase<DocumentCategory>, IDocumentCategoryRepository
    {
        public DocumentCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
    public interface IDocumentCategoryRepository : IRepository<DocumentCategory>
    {
    }
}
