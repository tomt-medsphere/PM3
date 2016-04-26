using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using System.Collections.Generic;

namespace PM3.Service
{
    // operations we'll expose
    public interface IBillingAccountTypeService
    {
        IEnumerable<BillingAccountType> GetBillingAccountTypes();
        BillingAccountType GetBillingAccountType(string id);
        void CreateBillingAccountType(BillingAccountType billingAccountType);
        void Update(BillingAccountType billingAccountType);
        void Delete(BillingAccountType billingAccountType);
        void SaveBillingAccountType();
    }

    // implementation of those operations
    public class BillingAccountTypeService : IBillingAccountTypeService
    {
        private readonly IBillingAccountTypeRepository _billingAccountTypeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BillingAccountTypeService(IBillingAccountTypeRepository billingAccountTypeRepository, IUnitOfWork unitOfWork)
        {
            this._billingAccountTypeRepository = billingAccountTypeRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<BillingAccountType> GetBillingAccountTypes()
        {
            var billingAccountTypes = _billingAccountTypeRepository.GetAll();
            return billingAccountTypes;
        }
        public BillingAccountType GetBillingAccountType(string id)
        {
            var billingAccountType = _billingAccountTypeRepository.GetById(id);
            return billingAccountType;
        }
        public void CreateBillingAccountType(BillingAccountType billingAccountType)
        {
            _billingAccountTypeRepository.Add(billingAccountType);
        }

        public void Update(BillingAccountType billingAccountType)
        {
            _billingAccountTypeRepository.Update(billingAccountType);
        }

        public void Delete(BillingAccountType billingAccountType)
        {
            _billingAccountTypeRepository.Delete(billingAccountType);
        }

        public void SaveBillingAccountType()
        {
            _unitOfWork.Commit();
        }
    }
}
