using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using System.Collections.Generic;

namespace PM3.Service
{
    // operations we'll expose
    public interface IDocumentCategoryService
    {
        IEnumerable<DocumentCategory> GetDocumentCategorys();
        DocumentCategory GetDocumentCategory(string id);
        void CreateDocumentCategory(DocumentCategory documentCategory);
        void Update(DocumentCategory documentCategory);
        void Delete(DocumentCategory documentCategory);
        void SaveDocumentCategory();
    }

    // implementation of those operations
    public class DocumentCategoryService : IDocumentCategoryService
    {
        private readonly IDocumentCategoryRepository _documentCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DocumentCategoryService(IDocumentCategoryRepository documentCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._documentCategoryRepository = documentCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<DocumentCategory> GetDocumentCategorys()
        {
            var documentCategorys = _documentCategoryRepository.GetAll();
            return documentCategorys;
        }
        public DocumentCategory GetDocumentCategory(string id)
        {
            var documentCategory = _documentCategoryRepository.GetById(id);
            return documentCategory;
        }
        public void CreateDocumentCategory(DocumentCategory documentCategory)
        {
            _documentCategoryRepository.Add(documentCategory);
        }

        public void Update(DocumentCategory documentCategory)
        {
            _documentCategoryRepository.Update(documentCategory);
        }

        public void Delete(DocumentCategory documentCategory)
        {
            _documentCategoryRepository.Delete(documentCategory);
        }

        public void SaveDocumentCategory()
        {
            _unitOfWork.Commit();
        }
    }
}
