using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using System.Collections.Generic;

namespace PM3.Service
{
    // operations we'll expose
    public interface IAccidentCodeService
    {
        IEnumerable<AccidentCode> GetAccidentCodes();
        AccidentCode GetAccidentCode(string id);
        void CreateAccidentCode(AccidentCode accidentcode);
        void Update(AccidentCode accidentCode);
        void Delete(AccidentCode accidentCode);
        void SaveAccidentCode();
    }

    // implementation of those operations
    public class AccidentCodeService : IAccidentCodeService
    {
        private readonly IAccidentCodeRepository _accidentCodeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AccidentCodeService(IAccidentCodeRepository accidentCodeRepository, IUnitOfWork unitOfWork)
        {
            this._accidentCodeRepository = accidentCodeRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<AccidentCode> GetAccidentCodes()
        {
            var accidentCodes = _accidentCodeRepository.GetAll();
            return accidentCodes;
        }
        public AccidentCode GetAccidentCode(string id)
        {
            var accidentCode = _accidentCodeRepository.GetById(id);
            return accidentCode;
        }
        public void CreateAccidentCode(AccidentCode accidentCode)
        {
            _accidentCodeRepository.Add(accidentCode);
        }

        public void Update(AccidentCode accidentCode)
        {
            _accidentCodeRepository.Update(accidentCode);
        }

        public void Delete(AccidentCode accidentCode)
        {
            _accidentCodeRepository.Delete(accidentCode);
        }

        public void SaveAccidentCode()
        {
            _unitOfWork.Commit();
        }
    }
}
